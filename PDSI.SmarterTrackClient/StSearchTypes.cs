using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StSearchTypes
    {
        public StSearchTypes()
        {
            StSearchFieldsInSearchTypes = new HashSet<StSearchFieldsInSearchTypes>();
        }

        public int SearchTypeId { get; set; }
        public string EnglishName { get; set; }
        public string DisplayName { get; set; }

        public ICollection<StSearchFieldsInSearchTypes> StSearchFieldsInSearchTypes { get; set; }
    }
}
