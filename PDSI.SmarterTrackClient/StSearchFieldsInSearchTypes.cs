using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StSearchFieldsInSearchTypes
    {
        public int SearchTypeId { get; set; }
        public int SearchFieldId { get; set; }
        public double Weight { get; set; }

        public StSearchFields SearchField { get; set; }
        public StSearchTypes SearchType { get; set; }
    }
}
