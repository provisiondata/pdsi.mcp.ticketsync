using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StKbCategories
    {
        public StKbCategories()
        {
            InverseKbCategoryIdParentNavigation = new HashSet<StKbCategories>();
            StAutoResponders = new HashSet<StAutoResponders>();
            StKbArticles = new HashSet<StKbArticles>();
            StKbSearchLogs = new HashSet<StKbSearchLogs>();
            StRolePermissions = new HashSet<StRolePermissions>();
        }

        public int KbCategoryId { get; set; }
        public int? KbCategoryIdParent { get; set; }
        public string CategoryName { get; set; }
        public bool IsPrivate { get; set; }
        public bool? IsVisible { get; set; }
        public bool ExcludedFromAutoSearches { get; set; }

        public StKbCategories KbCategoryIdParentNavigation { get; set; }
        public ICollection<StKbCategories> InverseKbCategoryIdParentNavigation { get; set; }
        public ICollection<StAutoResponders> StAutoResponders { get; set; }
        public ICollection<StKbArticles> StKbArticles { get; set; }
        public ICollection<StKbSearchLogs> StKbSearchLogs { get; set; }
        public ICollection<StRolePermissions> StRolePermissions { get; set; }
    }
}
