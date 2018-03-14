using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTaskEventLogs
    {
        public DateTime EventDateUtc { get; set; }
        public short Uniquifier { get; set; }
        public int EventTypeId { get; set; }
        public int TaskId { get; set; }
        public int? UserIdtakingAction { get; set; }
        public int InterfaceUsed { get; set; }
        public int? UserId { get; set; }
        public int? TaskStatusId { get; set; }
        public int? TaskPriorityId { get; set; }
        public int? OldUserId { get; set; }
        public int? OldTaskStatusId { get; set; }
        public int? OldTaskPriorityId { get; set; }

        public StEventTypes EventType { get; set; }
        public StTaskPriorities OldTaskPriority { get; set; }
        public StTaskStatuses OldTaskStatus { get; set; }
        public StUsers OldUser { get; set; }
        public StTasks Task { get; set; }
        public StTaskPriorities TaskPriority { get; set; }
        public StTaskStatuses TaskStatus { get; set; }
        public StUsers User { get; set; }
        public StUsers UserIdtakingActionNavigation { get; set; }
    }
}
