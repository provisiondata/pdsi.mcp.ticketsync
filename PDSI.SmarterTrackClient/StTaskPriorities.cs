using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTaskPriorities
    {
        public StTaskPriorities()
        {
            StRecurringTasks = new HashSet<StRecurringTasks>();
            StTaskEventLogsOldTaskPriority = new HashSet<StTaskEventLogs>();
            StTaskEventLogsTaskPriority = new HashSet<StTaskEventLogs>();
            StTasks = new HashSet<StTasks>();
        }

        public int TaskPriorityId { get; set; }
        public string EnglishName { get; set; }
        public string DisplayName { get; set; }
        public int SortOrder { get; set; }

        public ICollection<StRecurringTasks> StRecurringTasks { get; set; }
        public ICollection<StTaskEventLogs> StTaskEventLogsOldTaskPriority { get; set; }
        public ICollection<StTaskEventLogs> StTaskEventLogsTaskPriority { get; set; }
        public ICollection<StTasks> StTasks { get; set; }
    }
}
