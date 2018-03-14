using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StUserTrackingCookies
    {
        public StUserTrackingCookies()
        {
            StChats = new HashSet<StChats>();
            StKbSearchLogs = new HashSet<StKbSearchLogs>();
            StKbViewLogs = new HashSet<StKbViewLogs>();
            StNewsViewLogs = new HashSet<StNewsViewLogs>();
        }

        public long UserTrackingCookieId { get; set; }
        public int? UserId { get; set; }
        public DateTime DateFirstVisitUtc { get; set; }
        public DateTime DateLastVisitUtc { get; set; }

        public StUsers User { get; set; }
        public ICollection<StChats> StChats { get; set; }
        public ICollection<StKbSearchLogs> StKbSearchLogs { get; set; }
        public ICollection<StKbViewLogs> StKbViewLogs { get; set; }
        public ICollection<StNewsViewLogs> StNewsViewLogs { get; set; }
    }
}
