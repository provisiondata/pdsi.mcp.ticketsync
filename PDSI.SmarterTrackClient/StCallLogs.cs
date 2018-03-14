using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StCallLogs
    {
        public StCallLogs()
        {
            StCallLogAttachments = new HashSet<StCallLogAttachments>();
            StCallLogEventLogs = new HashSet<StCallLogEventLogs>();
            StCustomDataFieldsInCallLogs = new HashSet<StCustomDataFieldsInCallLogs>();
            StSearchTokensInCallLogs = new HashSet<StSearchTokensInCallLogs>();
            StTasks = new HashSet<StTasks>();
            StTicketLinks = new HashSet<StTicketLinks>();
        }

        public int CallLogId { get; set; }
        public int DepartmentId { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public int? CustomerUserId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerEmailAddress { get; set; }
        public string CallNumber { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public bool IsOutgoing { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateStartUtc { get; set; }
        public DateTime DateEndUtc { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public DateTime DateModifiedUtc { get; set; }
        public DateTime? DateDeletedUtc { get; set; }
        public bool IsIndexed { get; set; }

        public StGroups StGroups { get; set; }
        public StUsers User { get; set; }
        public ICollection<StCallLogAttachments> StCallLogAttachments { get; set; }
        public ICollection<StCallLogEventLogs> StCallLogEventLogs { get; set; }
        public ICollection<StCustomDataFieldsInCallLogs> StCustomDataFieldsInCallLogs { get; set; }
        public ICollection<StSearchTokensInCallLogs> StSearchTokensInCallLogs { get; set; }
        public ICollection<StTasks> StTasks { get; set; }
        public ICollection<StTicketLinks> StTicketLinks { get; set; }
    }
}
