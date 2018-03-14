using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTasks
    {
        public StTasks()
        {
            StSearchTokensInTasks = new HashSet<StSearchTokensInTasks>();
            StTagsInTasks = new HashSet<StTagsInTasks>();
            StTaskComments = new HashSet<StTaskComments>();
            StTaskEventLogs = new HashSet<StTaskEventLogs>();
        }

        public int TaskId { get; set; }
        public int TaskPriorityId { get; set; }
        public int TaskStatusId { get; set; }
        public int? UserId { get; set; }
        public int? TicketId { get; set; }
        public int? ChatId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsIndexed { get; set; }
        public bool IsStarted { get; set; }
        public bool IsDue { get; set; }
        public DateTime? DateStartUtc { get; set; }
        public DateTime? DateDueUtc { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public DateTime DateModifiedUtc { get; set; }
        public DateTime? DateDeletedUtc { get; set; }
        public int? ReminderMinutes { get; set; }
        public bool IsReminded { get; set; }
        public int? CallLogId { get; set; }
        public int? OriginalEstimate { get; set; }
        public int? RemainingEstimate { get; set; }
        public int? OriginalEstimateType { get; set; }
        public int? RemainingEstimateType { get; set; }
        public DateTime? DateCompletedUtc { get; set; }

        public StCallLogs CallLog { get; set; }
        public StChats Chat { get; set; }
        public StTaskPriorities TaskPriority { get; set; }
        public StTaskStatuses TaskStatus { get; set; }
        public StTickets Ticket { get; set; }
        public StUsers User { get; set; }
        public ICollection<StSearchTokensInTasks> StSearchTokensInTasks { get; set; }
        public ICollection<StTagsInTasks> StTagsInTasks { get; set; }
        public ICollection<StTaskComments> StTaskComments { get; set; }
        public ICollection<StTaskEventLogs> StTaskEventLogs { get; set; }
    }
}
