using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StAutoResponders
    {
        public StAutoResponders()
        {
            StDepartments = new HashSet<StDepartments>();
        }

        public int AutoResponderId { get; set; }
        public string DisplayName { get; set; }
        public bool IsHtml { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int? KbSearchCategoryId { get; set; }
        public int KbSearchMaxResults { get; set; }
        public string ViewOnlineLinkText { get; set; }
        public string KbBrowseText { get; set; }

        public StKbCategories KbSearchCategory { get; set; }
        public ICollection<StDepartments> StDepartments { get; set; }
    }
}
