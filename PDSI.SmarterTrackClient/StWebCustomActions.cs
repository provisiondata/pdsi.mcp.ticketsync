using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StWebCustomActions
    {
        public int WebCustomActionId { get; set; }
        public short? RoleId { get; set; }
        public string Title { get; set; }
        public int DisplayOrder { get; set; }
        public string LinkUrl { get; set; }
        public string LinkTarget { get; set; }
        public bool DisplayAsTab { get; set; }
        public int? BrandId { get; set; }

        public StBrands Brand { get; set; }
        public StRoles Role { get; set; }
    }
}
