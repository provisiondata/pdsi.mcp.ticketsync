using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTimeEstimates
    {
        public int DepartmentId { get; set; }
        public int GroupId { get; set; }
        public int EventTypeId { get; set; }
        public double MinuteCost { get; set; }
        public double DefaultHourlyPayRate { get; set; }

        public StEventTypes EventType { get; set; }
        public StGroups StGroups { get; set; }
    }
}
