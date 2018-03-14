using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StCannedCategories
    {
        public StCannedCategories()
        {
            InverseCannedCategoryIdParentNavigation = new HashSet<StCannedCategories>();
            StCannedReplies = new HashSet<StCannedReplies>();
        }

        public int CannedCategoryId { get; set; }
        public int? CannedCategoryIdParent { get; set; }
        public string CategoryName { get; set; }

        public StCannedCategories CannedCategoryIdParentNavigation { get; set; }
        public ICollection<StCannedCategories> InverseCannedCategoryIdParentNavigation { get; set; }
        public ICollection<StCannedReplies> StCannedReplies { get; set; }
    }
}
