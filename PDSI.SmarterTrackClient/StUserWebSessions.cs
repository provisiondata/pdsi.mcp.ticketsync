using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StUserWebSessions
    {
        public int UserWebSessionId { get; set; }
        public int? UserId { get; set; }
        public string SessionIdentifier { get; set; }
        public DateTime DateStartedUtc { get; set; }
        public DateTime DateLastActionUtc { get; set; }

        public StUsers User { get; set; }
    }
}
