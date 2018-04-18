using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PDSI.SmarterTrackClient;
using Serilog;

namespace PDSI.MCP.TicketSync.Jobs
{
    public class SmarterTrackJob : Job
    {
        protected SmarterTrackJob(ILogger logger, ISmarterTrackContext smarterTrackContext) : base(logger)
        {
            SmarterTrackContext = smarterTrackContext;
        }

        protected ISmarterTrackContext SmarterTrackContext { get; }

        public override Task<JobResult> ExecuteAsync() => throw new NotImplementedException();

        protected async Task<svcTicketsSoapClient> GetSmarterTrackTicketsServiceAsync()
        {
            var svc = new svcTicketsSoapClient(svcTicketsSoapClient.EndpointConfiguration.svcTicketsSoap12, SmarterTrackContext.Config.EndpointAddress);
            await svc.OpenAsync().ConfigureAwait(false);
            return svc;
        }

        protected async Task<IEnumerable<TicketInfo>> GetTicketsAsync(svcTicketsSoapClient svc)
        {
            var response = await svc.GetTicketsBySearchAsync(SmarterTrackContext.Config.AuthUserName, SmarterTrackContext.Config.AuthPassword, new ArrayOfString()).ConfigureAwait(false);
            var tickets = response.Body.GetTicketsBySearchResult.Tickets.OrderByDescending(t => t.LastReplyDateUtc).Take(SmarterTrackContext.Config.TicketScanLimit);
            return tickets;
        }

        protected async Task<IEnumerable<StCustomField>> GetAccountOrAssetFieldsAsync(svcTicketsSoapClient svc, TicketInfo ticket)
        {
            var list = new List<StCustomField>();
            var tcfl = await svc.GetTicketCustomFieldsListAsync(SmarterTrackContext.Config.AuthUserName, SmarterTrackContext.Config.AuthPassword, ticket.TicketNumber).ConfigureAwait(false);
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

        private static Boolean IsAccountOrAsset(StCustomField cf)
        {
            return String.Equals("Account", cf.Name, StringComparison.InvariantCultureIgnoreCase)
                || (String.Equals("Asset", cf.Name, StringComparison.InvariantCultureIgnoreCase) && !cf.Value.StartsWith("Pick one", StringComparison.InvariantCultureIgnoreCase));
        }

        protected async Task<String> GetTicketUrlAsync(svcTicketsSoapClient svc, TicketInfo ticket)
        {
            var result = await svc.GetTicketURLAsync(SmarterTrackContext.Config.AuthUserName, SmarterTrackContext.Config.AuthPassword, ticket.TicketNumber).ConfigureAwait(false);

            return result.Body.GetTicketURLResult.RequestResult;
        }


    }
}
