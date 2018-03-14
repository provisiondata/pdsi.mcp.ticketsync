using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StWhosOnFilterCondition
    {
        public int ConditionId { get; set; }
        public int FilterId { get; set; }
        public string ConditionValue { get; set; }
        public int Operator { get; set; }
        public int Field { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsDefault { get; set; }

        public StWhosOnFilter Filter { get; set; }
    }
}
