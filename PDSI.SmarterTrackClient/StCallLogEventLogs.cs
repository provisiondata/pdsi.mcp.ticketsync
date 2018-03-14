using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StCallLogEventLogs
    {
        public DateTime EventDateUtc { get; set; }
        public short Uniquifier { get; set; }
        public int EventTypeId { get; set; }
        public int CallLogId { get; set; }
        public int? UserIdtakingAction { get; set; }
        public int InterfaceUsed { get; set; }
        public int DepartmentId { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public int? OldDepartmentId { get; set; }
        public int? OldGroupId { get; set; }
        public int? OldUserId { get; set; }

        public StCallLogs CallLog { get; set; }
        public StEventTypes EventType { get; set; }
        public StGroups Old { get; set; }
        public StUsers OldUser { get; set; }
        public StGroups StGroups { get; set; }
        public StUsers User { get; set; }
        public StUsers UserIdtakingActionNavigation { get; set; }
    }
}
