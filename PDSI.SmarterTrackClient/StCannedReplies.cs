using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StCannedReplies
    {
        public StCannedReplies()
        {
            StCannedReplyEventLogs = new HashSet<StCannedReplyEventLogs>();
        }

        public int CannedReplyId { get; set; }
        public int CannedCategoryId { get; set; }
        public int DepartmentId { get; set; }
        public int? UserId { get; set; }
        public string Subject { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public DateTime DateModifiedUtc { get; set; }
        public DateTime DateLastReviewedUtc { get; set; }
        public string Body { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDraft { get; set; }
        public bool IsFlaggedForReview { get; set; }
        public bool? IsForTickets { get; set; }
        public bool? IsForChats { get; set; }
        public int? LanguageId { get; set; }

        public StCannedCategories CannedCategory { get; set; }
        public StDepartments Department { get; set; }
        public StLanguages Language { get; set; }
        public StUsers User { get; set; }
        public ICollection<StCannedReplyEventLogs> StCannedReplyEventLogs { get; set; }
    }
}
