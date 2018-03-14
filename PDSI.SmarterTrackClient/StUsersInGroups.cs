using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StUsersInGroups
    {
        public int DepartmentId { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public int TicketWeight { get; set; }
        public int ChatWeight { get; set; }
        public bool IsActiveForTickets { get; set; }
        public bool IsActiveForChats { get; set; }
        public bool IsGroupAdmin { get; set; }
        public bool IdleShouldHandoff { get; set; }
        public int IdleLogoffMinutes { get; set; }
        public bool IsAfk { get; set; }
        public DateTime? DateAfkStartedUtc { get; set; }
        public DateTime? DateLastTicketAssignedUtc { get; set; }
        public int MaxNewTickets { get; set; }
        public bool IsAutoActiveOnLogin { get; set; }
        public int RoundRobinOrder { get; set; }

        public StGroups StGroups { get; set; }
        public StUsers User { get; set; }
    }
}
