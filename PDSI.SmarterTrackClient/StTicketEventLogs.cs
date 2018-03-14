using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTicketEventLogs
    {
        public DateTime EventDateUtc { get; set; }
        public short Uniquifier { get; set; }
        public int EventTypeId { get; set; }
        public int TicketId { get; set; }
        public int? UserIdtakingAction { get; set; }
        public int InterfaceUsed { get; set; }
        public int DepartmentId { get; set; }
        public int GroupId { get; set; }
        public int? UserId { get; set; }
        public int? TicketStatusId { get; set; }
        public int? TicketPriorityId { get; set; }
        public long? TicketMessageId { get; set; }
        public int? EmailAddressId { get; set; }
        public int? OldDepartmentId { get; set; }
        public int? OldGroupId { get; set; }
        public int? OldUserId { get; set; }
        public int? OldTicketStatusId { get; set; }
        public int? OldTicketPriorityId { get; set; }

        public StEmailAddresses EmailAddress { get; set; }
        public StEventTypes EventType { get; set; }
        public StGroups Old { get; set; }
        public StTicketPriorities OldTicketPriority { get; set; }
        public StTicketStatuses OldTicketStatus { get; set; }
        public StUsers OldUser { get; set; }
        public StGroups StGroups { get; set; }
        public StTickets Ticket { get; set; }
        public StTicketMessages TicketMessage { get; set; }
        public StTicketPriorities TicketPriority { get; set; }
        public StTicketStatuses TicketStatus { get; set; }
        public StUsers User { get; set; }
        public StUsers UserIdtakingActionNavigation { get; set; }
    }
}
