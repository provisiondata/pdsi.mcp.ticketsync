using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTicketTimings
    {
        public DateTime TimingStartUtc { get; set; }
        public int TicketId { get; set; }
        public DateTime? TimingEndUtc { get; set; }
        public long? ElapsedSeconds { get; set; }
        public int DepartmentId { get; set; }
        public int GroupId { get; set; }
        public int? UserId { get; set; }
        public int TicketStatusId { get; set; }
        public int TicketPriorityId { get; set; }
        public bool CountInResponseTime { get; set; }
        public bool CountInInitialResponseTime { get; set; }

        public StGroups StGroups { get; set; }
        public StTickets Ticket { get; set; }
        public StTicketPriorities TicketPriority { get; set; }
        public StTicketStatuses TicketStatus { get; set; }
        public StUsers User { get; set; }
    }
}
