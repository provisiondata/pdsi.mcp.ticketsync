using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StEvents
    {
        public StEvents()
        {
            StEventActions = new HashSet<StEventActions>();
            StEventConditions = new HashSet<StEventConditions>();
        }

        public int EventId { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public int? Owner { get; set; }
        public string EventGroup { get; set; }
        public int EventGuid { get; set; }
        public string Guid { get; set; }
        public bool IsRepeating { get; set; }
        public long? RepeatFrequency { get; set; }
        public DateTime? DateLastOccurredUtc { get; set; }
        public DateTime DateLastModifiedUtc { get; set; }
        public bool IsActive { get; set; }
        public bool? Enabled { get; set; }

        public ICollection<StEventActions> StEventActions { get; set; }
        public ICollection<StEventConditions> StEventConditions { get; set; }
    }
}
