using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTimeLogs
    {
        public int TimeLogId { get; set; }
        public int? TicketId { get; set; }
        public int? ChatId { get; set; }
        public int? CallLogId { get; set; }
        public int? TaskId { get; set; }
        public int UserId { get; set; }
        public int? CustomerUserId { get; set; }
        public string CustomerEmailAddress { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public DateTime DateModifiedUtc { get; set; }
        public DateTime? DateDeletedUtc { get; set; }
        public DateTime DateStartUtc { get; set; }
        public DateTime DateEndUtc { get; set; }
        public bool IsBillable { get; set; }
        public bool IsDeleted { get; set; }
        public int? TagId { get; set; }

        public StTags Tag { get; set; }
    }
}
