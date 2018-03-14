using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StCustomDataFieldsForBrands
    {
        public int BrandId { get; set; }
        public int CustomFieldId { get; set; }
        public string DataContent { get; set; }

        public StBrands Brand { get; set; }
        public StCustomDataFields CustomField { get; set; }
    }
}
