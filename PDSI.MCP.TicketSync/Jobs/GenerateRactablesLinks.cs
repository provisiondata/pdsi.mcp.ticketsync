using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using PDSI.SmarterTrackClient;
using Serilog;

namespace PDSI.MCP.TicketSync.Jobs
{
    public class GenerateRactablesLinks : SmarterTrackJob
    {
        private readonly IRackTablesContext _ractablesContext;
        private readonly RackTables _config;

        public GenerateRactablesLinks(ILogger logger, IRackTablesContext ractablesContext, ISmarterTrackContext smarterTrackContext) : base(logger, smarterTrackContext)
        {
            _ractablesContext = ractablesContext;
            _config = ractablesContext.Config;
        }

        public override async Task<JobResult> ExecuteAsync()
        {
            var svc = await GetSmarterTrackTicketsServiceAsync();
            var tickets = await GetTicketsAsync(svc);
            foreach (var ticket in tickets)
            {
                var customFields = await GetAccountOrAssetFieldsAsync(svc, ticket).ConfigureAwait(false);
                var assetField = customFields.SingleOrDefault(cf => cf.Name.Equals("Asset", StringComparison.InvariantCultureIgnoreCase));
                if (assetField != null)
                {
                    var assetId = assetField.Value.Id();
                    var ticketUrl = await GetTicketUrlAsync(svc, ticket).ConfigureAwait(false);

                    var comment = await GetSoc2CommentAsync(svc, assetId).ConfigureAwait(false);
                    var notetext = _config.GenerateHtmlComments ? GenerateNoteTextHtml(ticketUrl) : GenerateNoteText(ticketUrl);
                    if (comment == null)
                    {
                        // Add comment
                        Logger.Information("[{TicketNumber}] Added #SOC2 Comment: {Comment}", ticket.TicketNumber, notetext);
                    }
                    else
                    {
                        // Update comment
                        Logger.Information("[{TicketNumber}] Updated #SOC2 Comment: {Comment}", ticket.TicketNumber, notetext);
                    }
                }
                else
                {
                    Logger.Verbose("[{TicketNumber}] Does not have Asset and/or Account", ticket.TicketNumber);
                }
            }
            await svc.CloseAsync().ConfigureAwait(false);

            return new JobResult() { };
        }

        private async Task<rtObjectLog> GetSoc2CommentAsync(svcTicketsSoapClient svc, Int32 object_id)
        {
            var list = await _ractablesContext.Connection.QueryAsync<rtObjectLog>("SELECT * FROM ObjectLog WHERE object_id = @object_id", new { object_id }).ConfigureAwait(false);
            return list.SingleOrDefault(log => _config.AuthUserName.Equals(log.user, StringComparison.InvariantCultureIgnoreCase) && log.content.Contains("#SOC2"));
        }

        private String GenerateNoteText(String ticketUrl)
        {
            var sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendLine($"#SOC2 {DateTimeOffset.Now}");
            return sb.ToString();
        }

        private String GenerateNoteTextHtml(String ticketUrl)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"<p>#SOC2 {DateTimeOffset.Now}</p>");

            return sb.ToString();
        }

    }
}
