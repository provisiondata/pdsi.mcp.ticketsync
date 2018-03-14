using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTicketPriorities
    {
        public StTicketPriorities()
        {
            StTicketEventLogsOldTicketPriority = new HashSet<StTicketEventLogs>();
            StTicketEventLogsTicketPriority = new HashSet<StTicketEventLogs>();
            StTicketTimings = new HashSet<StTicketTimings>();
            StTickets = new HashSet<StTickets>();
        }

        public int TicketPriorityId { get; set; }
        public string EnglishName { get; set; }
        public string DisplayName { get; set; }
        public int SortOrder { get; set; }

        public ICollection<StTicketEventLogs> StTicketEventLogsOldTicketPriority { get; set; }
        public ICollection<StTicketEventLogs> StTicketEventLogsTicketPriority { get; set; }
        public ICollection<StTicketTimings> StTicketTimings { get; set; }
        public ICollection<StTickets> StTickets { get; set; }
    }
}
