using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using PDSI.SmarterTrackClient;
using Serilog;

namespace PDSI.MCP.TicketSync.Jobs
{
    public class GenerateRactablesLinks : SmarterTrackJob
    {
        private readonly IRackTablesContext _ractablesContext;
        private readonly RackTables _config;

        public GenerateRactablesLinks(ILogger logger, IRackTablesContext racktablesContext, ISmarterTrackContext smarterTrackContext) : base(logger, smarterTrackContext)
        {
            _ractablesContext = racktablesContext ?? throw new ArgumentNullException(nameof(racktablesContext));
            _config = racktablesContext.Config;
        }

        public override async Task<JobResult> ExecuteAsync()
        {
            var tickets = await GetTicketsAsync(_config.TicketScanLimit);
            var counter = 0;
            foreach (var ticket in tickets)
            {
                Logger.LogTicket(++counter, ticket);
                try
                {
                    var customFields = await GetAccountOrAssetFieldsAsync(ticket).ConfigureAwait(false);
                    var assetField = customFields.SingleOrDefault(cf => cf.Name.Equals("Asset", StringComparison.InvariantCultureIgnoreCase));
                    if (assetField != null)
                    {
                        var object_id = assetField.Value.Id();
                        if (object_id > 0)
                        {
                            var ticketUrl = await GetTicketUrlAsync(ticket).ConfigureAwait(false);

                            var text = _config.GenerateHtmlComments 
                                ? GenerateNoteTextHtml(ticket, ticketUrl) 
                                : GenerateNoteText(ticket, ticketUrl);

                            var comment = await GetSoc2CommentAsync(object_id).ConfigureAwait(false);
                            if (comment == null)
                            {
                                // Add comment
                                var ol = new rtObjectLog() { object_id = object_id, user = _config.AuthUserName, date = DateTime.Now, content = text };
                                Logger.Debug("Inserting ObjectLog: object_id: {object_id} user: {user} date: {date} content: {content}", ol.object_id, ol.user, ol.date, ol.content);
                                await _ractablesContext.Connection.InsertAsync(ol).ConfigureAwait(false);
                                Logger.Information("[{TicketNumber}] Added ObjectLog #SOC2 Comment. object_id: {object_id}", ticket.TicketNumber, ol.object_id);
                            }
                            else
                            {
                                comment.content = text;
                                // Update comment
                                Logger.Debug("Updating ObjectLog: id: {id} object_id: {object_id} user: {user} date: {date} content: {content}",
                                    comment.id, comment.object_id, comment.user, comment.date, comment.content);
                                await _ractablesContext.Connection.UpdateAsync(comment).ConfigureAwait(false);
                                Logger.Information("[{TicketNumber}] Updated ObjectLog #SOC2 Comment. id: {id}", ticket.TicketNumber, comment.id);
                            }
                        }
                    }
                    else
                    {
                        Logger.Verbose("[{TicketNumber}] Does not have Asset and/or Account", ticket.TicketNumber);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Error(ex, $"{ex.GetType().Name}: {ex.Message}");
                }
            }

            return new JobResult() { };
        }

        private async Task<rtObjectLog> GetSoc2CommentAsync(Int32 object_id)
        {
            var list = await _ractablesContext.Connection.QueryAsync<rtObjectLog>("SELECT * FROM ObjectLog WHERE object_id = @object_id", new { object_id }).ConfigureAwait(false);
            return list.SingleOrDefault(log => _config.AuthUserName.Equals(log.user, StringComparison.InvariantCultureIgnoreCase) && (!String.IsNullOrWhiteSpace(log.content) && log.content.Contains("#SOC2")));
        }

        private String GenerateNoteText(TicketInfo ticket, String ticketUrl)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Referenced by [{ticket.TicketNumber}] {ticket.Subject}");
            sb.AppendLine($"{ticketUrl}");
            sb.AppendLine();
            sb.AppendLine($"#SOC2 {DateTimeOffset.Now}");
            return sb.ToString();
        }

        private String GenerateNoteTextHtml(TicketInfo ticket, String ticketUrl)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"<p>Referenced by [<a href=\"{ticketUrl}\">{ticket.TicketNumber}</a>] {ticket.Subject}</p>");
            sb.AppendLine($"<p>#SOC2 {DateTimeOffset.Now}</p>");
            return sb.ToString();
        }
    }
}
