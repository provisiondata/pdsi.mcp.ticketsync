using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StKbViewLogs
    {
        public int KbViewLogId { get; set; }
        public long? UserTrackingCookieId { get; set; }
        public int KbArticleId { get; set; }
        public int? KbSearchLogId { get; set; }
        public DateTime DateClickUtc { get; set; }

        public StKbArticles KbArticle { get; set; }
        public StKbSearchLogs KbSearchLog { get; set; }
        public StUserTrackingCookies UserTrackingCookie { get; set; }
    }
}
