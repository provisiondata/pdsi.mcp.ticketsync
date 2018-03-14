using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StNewsViewLogs
    {
        public int NewsViewLogId { get; set; }
        public int? NewsItemId { get; set; }
        public long? UserTrackingCookieId { get; set; }
        public DateTime DateClickUtc { get; set; }

        public StNewsItems NewsItem { get; set; }
        public StUserTrackingCookies UserTrackingCookie { get; set; }
    }
}
