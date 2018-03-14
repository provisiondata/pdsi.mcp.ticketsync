using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StThreadTags
    {
        public StThreadTags()
        {
            StThreadTagsInThreads = new HashSet<StThreadTagsInThreads>();
        }

        public int ThreadTagId { get; set; }
        public int NumOfUses { get; set; }
        public string Tag { get; set; }
        public int? BrandId { get; set; }
        public bool IsCategory { get; set; }
        public short SortOrder { get; set; }
        public short? RoleId { get; set; }

        public StBrands Brand { get; set; }
        public StRoles Role { get; set; }
        public ICollection<StThreadTagsInThreads> StThreadTagsInThreads { get; set; }
    }
}
