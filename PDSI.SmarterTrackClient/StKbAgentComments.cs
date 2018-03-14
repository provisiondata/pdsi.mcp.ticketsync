using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StKbAgentComments
    {
        public int KbAgentCommentId { get; set; }
        public int KbArticleId { get; set; }
        public int UserId { get; set; }
        public string CommentText { get; set; }
        public DateTime DateEnteredUtc { get; set; }

        public StKbArticles KbArticle { get; set; }
        public StUsers User { get; set; }
    }
}
