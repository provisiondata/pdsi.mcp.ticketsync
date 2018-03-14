using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StFileDirectories
    {
        public StFileDirectories()
        {
            InverseFileDirectoryIdParentNavigation = new HashSet<StFileDirectories>();
            StDepartments = new HashSet<StDepartments>();
            StFiles = new HashSet<StFiles>();
            StUsers = new HashSet<StUsers>();
        }

        public int FileDirectoryId { get; set; }
        public int? FileDirectoryIdParent { get; set; }
        public string DisplayName { get; set; }

        public StFileDirectories FileDirectoryIdParentNavigation { get; set; }
        public ICollection<StFileDirectories> InverseFileDirectoryIdParentNavigation { get; set; }
        public ICollection<StDepartments> StDepartments { get; set; }
        public ICollection<StFiles> StFiles { get; set; }
        public ICollection<StUsers> StUsers { get; set; }
    }
}
