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
            var tickets = await GetTicketsAsync(_config.TicketScanLimit);
            var counter = 0;
            foreach (var ticket in tickets)
            {
                Logger.LogTicket(++counter, ticket);
                try
                {
                    var rule = _config.Rules.SingleOrDefault(t => t.Matches(ticket));
                    if (rule != null)
                    {
                        if (rule.Action == TicketCloserConfig.Rule.TicketAction.Close && !ticket.IsOpen)
                        {
                            Logger.Debug("{Job} Ticket [{TicketNumber}] matches {Rule} but is already {Action}.", nameof(SmarterTrackTicketCloser), ticket.TicketNumber, rule.Name, rule.Action);
                            continue;
                        }
                        if (rule.Action == TicketCloserConfig.Rule.TicketAction.Delete && ticket.IsDeleted)
                        {
                            Logger.Debug("{Job} Ticket [{TicketNumber}] matches {Rule} but is already {Action}.", nameof(SmarterTrackTicketCloser), ticket.TicketNumber, rule.Name, rule.Action);
                            continue;
                        }

                        if (!String.IsNullOrWhiteSpace(rule.Account))
                        {
                            await SetTicketAccountAsync(ticket, rule.Account);
                        }
                        if (!String.IsNullOrWhiteSpace(rule.Asset))
                        {
                            await SetTicketAssetAsync(ticket, rule.Asset);
                        }
                        switch (rule.Action)
                        {
                            case TicketCloserConfig.Rule.TicketAction.Close:
                                await CloseTicketAsync(ticket, rule.Comment);
                                break;
                            case TicketCloserConfig.Rule.TicketAction.Delete:
                                await DeleteTicketAsync(ticket, rule.Comment);
                                break;
                        }
                        Logger.Information("{Job} Ticket [{TicketNumber}] matched {Rule} and was {Action}.", nameof(SmarterTrackTicketCloser), ticket.TicketNumber, rule.Name, rule.Action);
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

            public IEnumerable<Rule> Rules { get; set; }
            public Int32 TicketScanLimit { get; set; } = 500;

            public class Rule
            {
                public String Name { get; set; }
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
