using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StSignatures
    {
        public int SignatureId { get; set; }
        public int? BrandId { get; set; }
        public int? DepartmentId { get; set; }
        public int? GroupId { get; set; }
        public string Signature { get; set; }

        public StBrands Brand { get; set; }
        public StGroups StGroups { get; set; }
    }
}
