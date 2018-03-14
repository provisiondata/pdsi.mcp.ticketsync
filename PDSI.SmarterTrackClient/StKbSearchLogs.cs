using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StKbSearchLogs
    {
        public StKbSearchLogs()
        {
            StKbViewLogs = new HashSet<StKbViewLogs>();
        }

        public int KbSearchLogId { get; set; }
        public long? UserTrackingCookieId { get; set; }
        public DateTime DateSearchUtc { get; set; }
        public string SearchText { get; set; }
        public int ArticleResultCount { get; set; }
        public int ArticleViewCount { get; set; }
        public int? KbCategoryId { get; set; }
        public int? KbArticleId { get; set; }

        public StKbArticles KbArticle { get; set; }
        public StKbCategories KbCategory { get; set; }
        public StUserTrackingCookies UserTrackingCookie { get; set; }
        public ICollection<StKbViewLogs> StKbViewLogs { get; set; }
    }
}
