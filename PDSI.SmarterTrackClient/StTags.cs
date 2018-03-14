using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTags
    {
        public StTags()
        {
            StTagsInRecurringTasks = new HashSet<StTagsInRecurringTasks>();
            StTagsInTasks = new HashSet<StTagsInTasks>();
            StTimeLogs = new HashSet<StTimeLogs>();
        }

        public int TagId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<StTagsInRecurringTasks> StTagsInRecurringTasks { get; set; }
        public ICollection<StTagsInTasks> StTagsInTasks { get; set; }
        public ICollection<StTimeLogs> StTimeLogs { get; set; }
    }
}
