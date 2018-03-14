using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StKbDailyStats
    {
        public int KbArticleId { get; set; }
        public int Visits { get; set; }
        public DateTime DateUtc { get; set; }

        public StKbArticles KbArticle { get; set; }
    }
}
