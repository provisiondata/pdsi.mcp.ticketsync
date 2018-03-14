using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StKbArticleComments
    {
        public StKbArticleComments()
        {
            InverseKbArticleCommentIdParentNavigation = new HashSet<StKbArticleComments>();
            StKbArticleCommentAbuse = new HashSet<StKbArticleCommentAbuse>();
        }

        public int KbArticleCommentId { get; set; }
        public int? KbArticleCommentIdParent { get; set; }
        public int KbArticleId { get; set; }
        public int? UserId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public DateTime DateModifiedUtc { get; set; }
        public DateTime? DateRejectedUtc { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string BodyText { get; set; }
        public bool IsModerated { get; set; }
        public bool IsRejected { get; set; }
        public bool IsAbusive { get; set; }
        public string Ipaddress { get; set; }

        public StKbArticles KbArticle { get; set; }
        public StKbArticleComments KbArticleCommentIdParentNavigation { get; set; }
        public StUsers User { get; set; }
        public ICollection<StKbArticleComments> InverseKbArticleCommentIdParentNavigation { get; set; }
        public ICollection<StKbArticleCommentAbuse> StKbArticleCommentAbuse { get; set; }
    }
}
