using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StWhosOnFilter
    {
        public StWhosOnFilter()
        {
            StWhosOnFilterCondition = new HashSet<StWhosOnFilterCondition>();
        }

        public int FilterId { get; set; }
        public int? BrandId { get; set; }
        public string FilterName { get; set; }
        public bool IsDefault { get; set; }

        public StBrands Brand { get; set; }
        public ICollection<StWhosOnFilterCondition> StWhosOnFilterCondition { get; set; }
    }
}
