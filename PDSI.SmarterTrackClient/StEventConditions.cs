using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StEventConditions
    {
        public int EventConditionId { get; set; }
        public int EventId { get; set; }
        public string DescriptionResourceId { get; set; }
        public string EventValue1 { get; set; }
        public string EventValue2 { get; set; }
        public string EventCondition { get; set; }
        public string EventKey { get; set; }
        public string EventType { get; set; }
        public bool IsAffectReset { get; set; }

        public StEvents Event { get; set; }
    }
}
