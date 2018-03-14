using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StRebalanceRules
    {
        public StRebalanceRules()
        {
            StUsersInRebalanceRules = new HashSet<StUsersInRebalanceRules>();
        }

        public int RebalanceRuleId { get; set; }
        public string RuleName { get; set; }
        public int DepartmentId { get; set; }
        public int GroupId { get; set; }
        public bool IncludeAllUsersInGroup { get; set; }
        public DateTime? DateLastRunUtc { get; set; }
        public int? HoldSecondsCompose { get; set; }
        public int? HoldSecondsTicketRead { get; set; }
        public int? HoldSecondsTicketAssigned { get; set; }
        public int? HoldSecondsPinnedTicket { get; set; }
        public int? ExecuteOnIntervalSeconds { get; set; }
        public bool ExecuteOnAgentActivate { get; set; }
        public bool ExecuteOnAgentDeactivate { get; set; }
        public DateTime? ExecuteAtTimeUtc1 { get; set; }
        public DateTime? ExecuteAtTimeUtc2 { get; set; }
        public DateTime? ExecuteAtTimeUtc3 { get; set; }

        public StGroups StGroups { get; set; }
        public ICollection<StUsersInRebalanceRules> StUsersInRebalanceRules { get; set; }
    }
}
