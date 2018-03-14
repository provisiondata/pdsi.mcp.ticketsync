using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTaskStatuses
    {
        public StTaskStatuses()
        {
            StRecurringTasks = new HashSet<StRecurringTasks>();
            StTaskEventLogsOldTaskStatus = new HashSet<StTaskEventLogs>();
            StTaskEventLogsTaskStatus = new HashSet<StTaskEventLogs>();
            StTasks = new HashSet<StTasks>();
        }

        public int TaskStatusId { get; set; }
        public string EnglishName { get; set; }
        public string DisplayName { get; set; }
        public int SortOrder { get; set; }
        public bool IsActive { get; set; }
        public bool IsOpen { get; set; }

        public ICollection<StRecurringTasks> StRecurringTasks { get; set; }
        public ICollection<StTaskEventLogs> StTaskEventLogsOldTaskStatus { get; set; }
        public ICollection<StTaskEventLogs> StTaskEventLogsTaskStatus { get; set; }
        public ICollection<StTasks> StTasks { get; set; }
    }
}
