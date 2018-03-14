using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StThreadUserFlags
    {
        public int ThreadId { get; set; }
        public int UserId { get; set; }
        public DateTime? DateLastChangedUtc { get; set; }
        public DateTime? DateLastReadUtc { get; set; }
        public DateTime? DateLastSubscriptionEmailUtc { get; set; }
        public bool IsSubscribed { get; set; }

        public StThreads Thread { get; set; }
        public StUsers User { get; set; }
    }
}
