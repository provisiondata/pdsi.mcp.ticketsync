using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSI.SmarterTrackClient;
using Serilog;

namespace PDSI.MCP.TicketSync.Jobs
{
    public class GenerateSmarterTrackCommentLinks : SmarterTrackJob
    {
        private readonly SmarterTrack _config;

        public GenerateSmarterTrackCommentLinks(ILogger logger, ISmarterTrackContext smarterTrack) : base(logger, smarterTrack)
        {
            _config = smarterTrack.Config;
        }

        public override async Task<JobResult> ExecuteAsync()
        {
            var svc = await GetSmarterTrackTicketsServiceAsync();
            var tickets = await GetTicketsAsync(svc);
            foreach (var ticket in tickets)
            {
                try
                {
                    Logger.Debug("{Job} Processing Ticket [{TicketNumber}]", nameof(GenerateSmarterTrackCommentLinks), ticket.TicketNumber);

                    var customFields = await GetAccountOrAssetFieldsAsync(svc, ticket).ConfigureAwait(false);
                    if (customFields.Any())
                    {
                        var comment = await GetSoc2CommentAsync(svc, ticket).ConfigureAwait(false);
                        var notetext = _config.GenerateHtmlComments ? GenerateNoteTextHtml(customFields) : GenerateNoteText(customFields);
                        if (comment == null)
                        {
                            // Add comment
                            var result = await svc.AddTicketNoteHtmlWithDateAsync(_config.AuthUserName, _config.AuthPassword, ticket.TicketNumber, _config.MessageType, notetext, DateTime.UtcNow);
                            Logger.Information("[{TicketNumber}] Added #SOC2 Comment.", ticket.TicketNumber);
                        }
                        else
                        {
                            // Update comment
                            var result = await svc.EditTicketNoteAsync(_config.AuthUserName, _config.AuthPassword, comment.CommentId, ticket.TicketNumber, _config.MessageType, notetext);
                            Logger.Information("[{TicketNumber}] Updated #SOC2 Comment: {CommentId}", ticket.TicketNumber, comment.CommentId);
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
            await svc.CloseAsync().ConfigureAwait(false);

            return new JobResult() { };
        }

        private async Task<TicketCommentInfo> GetSoc2CommentAsync(svcTicketsSoapClient svc, TicketInfo ticket)
        {
            var list = await GetCommentsAsync(svc, ticket).ConfigureAwait(false);
            return list.SingleOrDefault(comment => comment.UserId == _config.PdsiMcpUserId && comment.CommentText.Contains("#SOC2"));
        }

        private async Task<List<TicketCommentInfo>> GetCommentsAsync(svcTicketsSoapClient svc, TicketInfo ticket)
        {
            var list = new List<TicketCommentInfo>();
            var tcpl = await svc.GetTicketConversationPartListAsync(_config.AuthUserName, _config.AuthPassword, ticket.ID).ConfigureAwait(false);
            foreach (var part in tcpl.Body.GetTicketConversationPartListResult.Parts)
            {
                switch (part.Type)
                {
                    case 1: // Message
                        //var message = await svc.GetTicketMessagePlainTextAsync(_config.AuthUserName, _config.AuthPassword, part.PartId).ConfigureAwait(false);
                        break;
                    case 10: // Comment
                    case 11: // Transfer Comment
                    case 12: // Resolution Comment
                        var comment = await svc.GetTicketNoteAsync(_config.AuthUserName, _config.AuthPassword, (Int32)part.PartId).ConfigureAwait(false);
                        list.Add(comment.Body.GetTicketNoteResult.Comment);
                        break;
                    default:
                        Logger.Debug("[{TicketNumber}] Don't know what part Type '{Type}' is.", ticket.TicketNumber, part.Type);
                        break;
                }
            }
            return list;
        }

        private String GenerateNoteText(IEnumerable<StCustomField> customFields)
        {
            var sb = new StringBuilder();
            var account = customFields.SingleOrDefault(c => c.Name.Equals("Account", StringComparison.InvariantCultureIgnoreCase));
            if (account != null && account.Value.Id() > 0)
            {
                sb.AppendLine($"Account: {account.Value}");
                sb.AppendLine($"Account URL: {_config.AccountUrlTemplate.Replace("{{AccountId}}", account.Value.Id().ToString())}");
                sb.AppendLine();
            }
            var asset = customFields.SingleOrDefault(c => c.Name.Equals("Asset", StringComparison.InvariantCultureIgnoreCase));
            if (asset != null && account.Value.Id() > 0)
            {
                sb.AppendLine($"Asset: {asset.Value}");
                sb.AppendLine($"Asset URL: {_config.AssetUrlTemplate.Replace("{{AssetId}}", asset.Value.Id().ToString())}");
                sb.AppendLine();
            }
            sb.AppendLine();
            sb.AppendLine($"#SOC2 {DateTimeOffset.Now}");
            return sb.ToString();
        }

        private String GenerateNoteTextHtml(IEnumerable<StCustomField> customFields)
        {
            var sb = new StringBuilder();
            sb.AppendLine("<p>#SOC2</p>");
            var account = customFields.SingleOrDefault(c => c.Name.Equals("Account", StringComparison.InvariantCultureIgnoreCase));
            if (account != null)
            {
                sb.AppendLine($"<p>Account: <a href=\"{_config.AccountUrlTemplate.Replace("{{AccountId}}", account.Value.Id().ToString())}\">{account.Value}</a></p>");
            }
            var asset = customFields.SingleOrDefault(c => c.Name.Equals("Asset", StringComparison.InvariantCultureIgnoreCase));
            if (asset != null)
            {
                sb.AppendLine($"<p>Asset: <a href=\"{_config.AssetUrlTemplate.Replace("{{AssetId}}", asset.Value.Id().ToString())}\">{asset.Value}</a></p>");
            }
            return sb.ToString();
        }

    }
}
