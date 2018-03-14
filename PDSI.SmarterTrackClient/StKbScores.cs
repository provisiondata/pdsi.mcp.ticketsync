using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StKbScores
    {
        public int KbArticleId { get; set; }
        public long UserTrackingCookieId { get; set; }
        public int Score { get; set; }

        public StKbArticles KbArticle { get; set; }
    }
}
