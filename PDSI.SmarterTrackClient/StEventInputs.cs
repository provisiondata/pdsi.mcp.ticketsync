using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StEventInputs
    {
        public int EventInputId { get; set; }
        public int EventActionId { get; set; }
        public string DescriptionResourceId { get; set; }
        public string EventValue { get; set; }
        public string EventKey { get; set; }

        public StEventActions EventAction { get; set; }
    }
}
