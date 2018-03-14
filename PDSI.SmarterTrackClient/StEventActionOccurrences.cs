using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StEventActionOccurrences
    {
        public int EventActionOccurenceId { get; set; }
        public int EventActionId { get; set; }
        public string ConstraintKey { get; set; }
        public DateTime DateOccurredUtc { get; set; }

        public StEventActions EventAction { get; set; }
    }
}
