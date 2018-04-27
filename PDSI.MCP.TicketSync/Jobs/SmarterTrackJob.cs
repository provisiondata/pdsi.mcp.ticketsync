using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PDSI.SmarterTrackClient;
using Serilog;

namespace PDSI.MCP.TicketSync.Jobs
{
    public abstract class SmarterTrackJob : Job
    {
        private readonly Lazy<svcTicketsSoapClient> _lazyService;

        protected SmarterTrackJob(ILogger logger, ISmarterTrackContext smarterTrackContext) : base(logger)
        {
            SmarterTrackContext = smarterTrackContext;
            Config = smarterTrackContext.Config;
            _lazyService = new Lazy<svcTicketsSoapClient>(GetSmarterTrackTicketsService);
        }

        private svcTicketsSoapClient Service => _lazyService.Value;

        protected ISmarterTrackContext SmarterTrackContext { get; }
        private SmarterTrack Config { get; }

        protected Task CloseTicketAsync(TicketInfo ticket, String comment)
        {
            Logger.Information("{Job} Closed Ticket [{TicketNumber}] {comment}", GetType().Name, ticket.TicketNumber, comment);
            return Service.CloseTicketAsync(Config.AuthUserName, Config.AuthPassword, ticket.TicketNumber, comment);
        }

        protected async Task DeleteTicketAsync(TicketInfo ticket, String comment)
        {
            if (!String.IsNullOrWhiteSpace(comment))
            {
                await Service.AddTicketNoteHtmlWithDateAsync(Config.AuthUserName, Config.AuthPassword, ticket.TicketNumber, "general", comment, DateTime.UtcNow);
            }
            Logger.Information("{Job} Deleted Ticket [{TicketNumber}]", GetType().Name, ticket.TicketNumber);
            await Service.DeleteTicketAsync(Config.AuthUserName, Config.AuthPassword, ticket.ID);
        }

        protected svcTicketsSoapClient GetSmarterTrackTicketsService()
        {
            return new svcTicketsSoapClient(svcTicketsSoapClient.EndpointConfiguration.svcTicketsSoap12, Config.EndpointAddress);
        }

        protected async Task<IEnumerable<TicketInfo>> GetTicketsAsync()
        {
            var response = await Service.GetTicketsBySearchAsync(Config.AuthUserName, Config.AuthPassword, new ArrayOfString()).ConfigureAwait(false);
            var tickets = response.Body.GetTicketsBySearchResult.Tickets.OrderByDescending(t => t.LastReplyDateUtc).Take(Config.TicketScanLimit);
            return tickets;
        }

        protected async Task<IEnumerable<StCustomField>> GetAccountOrAssetFieldsAsync(TicketInfo ticket)
        {
            var list = new List<StCustomField>();
            var tcfl = await Service.GetTicketCustomFieldsListAsync(Config.AuthUserName, Config.AuthPassword, ticket.TicketNumber).ConfigureAwait(false);
            foreach (var result in tcfl.Body.GetTicketCustomFieldsListResult.RequestResults)
            {
                var cf = result.ParseCustomField();
                if (IsAccountOrAsset(cf))
                {
                    list.Add(cf);
                }
            }
            return list;
        }

        protected async Task<List<TicketCommentInfo>> GetCommentsAsync(TicketInfo ticket)
        {
            var list = new List<TicketCommentInfo>();
            var tcpl = await Service.GetTicketConversationPartListAsync(Config.AuthUserName, Config.AuthPassword, ticket.ID).ConfigureAwait(false);
            foreach (var part in tcpl.Body.GetTicketConversationPartListResult.Parts)
            {
                switch (part.Type)
                {
                    case 1: // Message
                        //var message = await svc.GetTicketMessagePlainTextAsync(Config.AuthUserName, Config.AuthPassword, part.PartId).ConfigureAwait(false);
                        break;
                    case 10: // Comment
                    case 11: // Transfer Comment
                    case 12: // Resolution Comment
                        var comment = await Service.GetTicketNoteAsync(Config.AuthUserName, Config.AuthPassword, (Int32)part.PartId).ConfigureAwait(false);
                        list.Add(comment.Body.GetTicketNoteResult.Comment);
                        break;
                    default:
                        Logger.Debug("[{TicketNumber}] Don't know what part Type '{Type}' is.", ticket.TicketNumber, part.Type);
                        break;
                }
            }
            return list;
        }

        protected async Task AddTicketNoteHtmlWithDateAsync(TicketInfo ticket, String notetext)
        {
            await Service.AddTicketNoteHtmlWithDateAsync(Config.AuthUserName, Config.AuthPassword, ticket.TicketNumber, Config.MessageType, notetext, DateTime.UtcNow);
        }

        protected async Task EditTicketNoteAsync(TicketCommentInfo comment, TicketInfo ticket, String notetext)
        {
            await Service.EditTicketNoteAsync(Config.AuthUserName, Config.AuthPassword, comment.CommentId, ticket.TicketNumber, Config.MessageType, notetext);
        }

        protected async Task SetTicketCustomFieldsAsync(TicketInfo ticket, ArrayOfString arrayOfString)
        {
            var result = await Service.SetTicketCustomFieldsAsync(Config.AuthUserName, Config.AuthPassword, ticket.TicketNumber, arrayOfString);
        }

        private static Boolean IsAccountOrAsset(StCustomField cf)
        {
            return String.Equals("Account", cf.Name, StringComparison.InvariantCultureIgnoreCase)
                || (String.Equals("Asset", cf.Name, StringComparison.InvariantCultureIgnoreCase) && !cf.Value.StartsWith("Pick one", StringComparison.InvariantCultureIgnoreCase));
        }

        protected async Task<String> GetTicketUrlAsync(TicketInfo ticket)
        {
            var result = await Service.GetTicketURLAsync(Config.AuthUserName, Config.AuthPassword, ticket.TicketNumber).ConfigureAwait(false);

            return result.Body.GetTicketURLResult.RequestResult;
        }
    }
}
