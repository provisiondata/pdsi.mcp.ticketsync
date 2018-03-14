using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTicketStatuses
    {
        public StTicketStatuses()
        {
            StTicketEventLogsOldTicketStatus = new HashSet<StTicketEventLogs>();
            StTicketEventLogsTicketStatus = new HashSet<StTicketEventLogs>();
            StTicketTimings = new HashSet<StTicketTimings>();
            StTickets = new HashSet<StTickets>();
        }

        public int TicketStatusId { get; set; }
        public string EnglishName { get; set; }
        public string DisplayName { get; set; }
        public int SortOrder { get; set; }
        public bool IsOpen { get; set; }
        public bool IsActive { get; set; }
        public bool IsLocked { get; set; }

        public ICollection<StTicketEventLogs> StTicketEventLogsOldTicketStatus { get; set; }
        public ICollection<StTicketEventLogs> StTicketEventLogsTicketStatus { get; set; }
        public ICollection<StTicketTimings> StTicketTimings { get; set; }
        public ICollection<StTickets> StTickets { get; set; }
    }
}
