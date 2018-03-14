using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StEventReminders
    {
        public int ReminderId { get; set; }
        public int? UserId { get; set; }
        public string Subject { get; set; }
        public string BodyText { get; set; }
        public DateTime TimeOccurredUtc { get; set; }
        public DateTime? SnoozeTimeUtc { get; set; }

        public StUsers User { get; set; }
    }
}
