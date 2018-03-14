using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTagsInRecurringTasks
    {
        public int TagsInRecurringTasksId { get; set; }
        public int RecurringTaskId { get; set; }
        public int TagId { get; set; }
        public DateTime DateAddedUtc { get; set; }

        public StRecurringTasks RecurringTask { get; set; }
        public StTags Tag { get; set; }
    }
}
