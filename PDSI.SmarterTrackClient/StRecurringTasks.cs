using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StRecurringTasks
    {
        public StRecurringTasks()
        {
            StRecurringTaskDays = new HashSet<StRecurringTaskDays>();
            StTagsInRecurringTasks = new HashSet<StTagsInRecurringTasks>();
        }

        public int RecurringTaskId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public int UserId { get; set; }
        public DateTime StartDateUtc { get; set; }
        public int RecurringTaskType { get; set; }
        public int TaskPriorityId { get; set; }
        public int TaskStatusId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public int? OriginalEstimate { get; set; }
        public int? RemainingEstimate { get; set; }
        public int? OriginalEstimateType { get; set; }
        public int? RemainingEstimateType { get; set; }
        public int TaskTypeInterval { get; set; }
        public DateTime NextScheduledDateUtc { get; set; }
        public bool IsDeleted { get; set; }

        public StTaskPriorities TaskPriority { get; set; }
        public StTaskStatuses TaskStatus { get; set; }
        public StUsers User { get; set; }
        public ICollection<StRecurringTaskDays> StRecurringTaskDays { get; set; }
        public ICollection<StTagsInRecurringTasks> StTagsInRecurringTasks { get; set; }
    }
}
