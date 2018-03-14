using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StEventActions
    {
        public StEventActions()
        {
            StEventActionOccurrences = new HashSet<StEventActionOccurrences>();
            StEventInputs = new HashSet<StEventInputs>();
        }

        public int EventActionId { get; set; }
        public int EventId { get; set; }
        public string ConstraintKey { get; set; }
        public bool IsConstrained { get; set; }
        public long ConstraintFrequency { get; set; }
        public string ResourceId { get; set; }
        public string Guid { get; set; }
        public string EventKey { get; set; }
        public DateTime DateLastOccurredUtc { get; set; }

        public StEvents Event { get; set; }
        public ICollection<StEventActionOccurrences> StEventActionOccurrences { get; set; }
        public ICollection<StEventInputs> StEventInputs { get; set; }
    }
}
