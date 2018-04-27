using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using PDSI.SmarterTrackClient;
using Serilog;
using StructureMap;

namespace PDSI.MCP.TicketSync.Jobs
{
    public class SmarterTrackTicketCloser : SmarterTrackJob
    {
        private readonly TicketCloserConfig _config;

        public SmarterTrackTicketCloser(ILogger logger, ISmarterTrackContext smarterTrackContext, TicketCloserConfig config) : base(logger, smarterTrackContext)
        {
            _config = config;
        }

        public override async Task<JobResult> ExecuteAsync()
        {
            var tickets = await GetTicketsAsync();
            foreach (var ticket in tickets)
            {
                try
                {
                    var m = _config.Tickets.SingleOrDefault(t => t.Matches(ticket));
                    if (m != null)
                    {
                        Logger.Debug("{Job} Processing Ticket [{TicketNumber}]", nameof(SmarterTrackTicketCloser), ticket.TicketNumber);
                        if (m.Action == TicketCloserConfig.Ticket.TicketAction.Close && !ticket.IsOpen) continue;
                        if (m.Action == TicketCloserConfig.Ticket.TicketAction.Delete && ticket.IsDeleted) continue;
                        Logger.Debug("{Job} Ticket [{TicketNumber}] is closeable.", nameof(SmarterTrackTicketCloser), ticket.TicketNumber);
                        if (!String.IsNullOrWhiteSpace(m.Account))
                        {
                            await SetTicketAccountAsync(ticket, m.Account);
                        }
                        if (!String.IsNullOrWhiteSpace(m.Asset))
                        {
                            await SetTicketAssetAsync(ticket, m.Account);
                        }
                        switch (m.Action)
                        {
                            case TicketCloserConfig.Ticket.TicketAction.Close:
                                await CloseTicketAsync(ticket, m.Comment);
                                break;
                            case TicketCloserConfig.Ticket.TicketAction.Delete:
                                await DeleteTicketAsync(ticket, m.Comment);
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.Error(ex, $"{ex.GetType().Name}: {ex.Message}");
                }
            }

            return new JobResult() { };
        }

        private Task SetTicketAssetAsync(TicketInfo ticket, String asset)
        {
            return SetTicketCustomFieldsAsync(ticket, new ArrayOfString() { $"Asset={asset}" });
        }

        private Task SetTicketAccountAsync(TicketInfo ticket, String account)
        {
            return SetTicketCustomFieldsAsync(ticket, new ArrayOfString() { $"Account={account}" });
        }

        public class SmarterTrackTicketCloserRegistry : Registry
        {
            public SmarterTrackTicketCloserRegistry()
            {
                For<TicketCloserConfig>().Use(c => c.GetInstance<IConfiguration>().GetSection(TicketCloserConfig.SectionName).Get<TicketCloserConfig>());
            }
        }
        public class TicketCloserConfig
        {
            public static String SectionName => "TicketCloser";

            public IEnumerable<Ticket> Tickets { get; set; }

            public class Ticket
            {
                public String Subject { get; set; } = String.Empty;
                public String Email { get; set; } = String.Empty;
                public String Account { get; set; } = String.Empty;
                public String Asset { get; set; } = String.Empty;
                public String Comment { get; set; } = String.Empty;
                public TicketAction Action { get; set; }

                public enum TicketAction
                {
                    Close,
                    Delete
                }

                public Boolean Matches(TicketInfo ticketInfo)
                {
                    if (!String.IsNullOrWhiteSpace(Subject) && !String.Equals(ticketInfo.Subject, Subject, StringComparison.InvariantCultureIgnoreCase))
                    {
                        return false;
                    }

                    if (!String.IsNullOrWhiteSpace(Email) && !String.Equals(ticketInfo.CustomerEmailAddress, Email, StringComparison.InvariantCultureIgnoreCase))
                    {
                        return false;
                    }

                    return true;
                }
            }
        }
    }
}
