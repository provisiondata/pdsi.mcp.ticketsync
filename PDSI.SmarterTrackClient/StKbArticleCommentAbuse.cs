using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StKbArticleCommentAbuse
    {
        public int KbArticleCommentAbuseId { get; set; }
        public int KbArticleCommentId { get; set; }
        public int UserId { get; set; }
        public DateTime DateReportedUtc { get; set; }

        public StKbArticleComments KbArticleComment { get; set; }
        public StUsers User { get; set; }
    }
}
