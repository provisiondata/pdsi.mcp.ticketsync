using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StConversationAbuse
    {
        public int UserIdreported { get; set; }
        public int UserIdreporting { get; set; }
        public short ModerationStatus { get; set; }
        public short TypeOfAbuse { get; set; }

        public StUsers UserIdreportedNavigation { get; set; }
        public StUsers UserIdreportingNavigation { get; set; }
    }
}
