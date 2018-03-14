using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StNewsEventLogs
    {
        public DateTime EventDateUtc { get; set; }
        public short Uniquifier { get; set; }
        public int EventTypeId { get; set; }
        public int NewsItemId { get; set; }
        public int UserIdtakingAction { get; set; }

        public StEventTypes EventType { get; set; }
        public StNewsItems NewsItem { get; set; }
        public StUsers UserIdtakingActionNavigation { get; set; }
    }
}
