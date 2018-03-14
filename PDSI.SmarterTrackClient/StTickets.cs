using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
	public partial class StTickets
	{
		public StTickets() {
			StCustomDataFieldsInTickets = new HashSet<StCustomDataFieldsInTickets>();
			StSearchTokensInTickets = new HashSet<StSearchTokensInTickets>();
			StSurveyOfferedUserContext = new HashSet<StSurveyOfferedUserContext>();
			StTasks = new HashSet<StTasks>();
			StThreads = new HashSet<StThreads>();
			StTicketAttachments = new HashSet<StTicketAttachments>();
			StTicketComments = new HashSet<StTicketComments>();
			StTicketEmails = new HashSet<StTicketEmails>();
			StTicketEventLogs = new HashSet<StTicketEventLogs>();
			StTicketLinksTicket = new HashSet<StTicketLinks>();
			StTicketLinksTicketIdSecondaryNavigation = new HashSet<StTicketLinks>();
			StTicketMerges = new HashSet<StTicketMerges>();
			StTicketMessages = new HashSet<StTicketMessages>();
			StTicketTimings = new HashSet<StTicketTimings>();
		}

		public override String ToString() => $"{nameof(StTickets)} [{TicketNumber}] {Subject} <{CustomerEmailAddress}>";

		public int TicketId { get; set; }
		public string TicketNumber { get; set; }
		public DateTime DateOpenedUtc { get; set; }
		public int TicketPriorityId { get; set; }
		public int TicketStatusId { get; set; }
		public int DepartmentId { get; set; }
		public int GroupId { get; set; }
		public int? UserId { get; set; }
		public string Subject { get; set; }
		public string CustomerEmailAddress { get; set; }
		public DateTime IdleStartTimeUtc { get; set; }
		public int ReplyCountIn { get; set; }
		public int ReplyCountOut { get; set; }
		public bool IsIndexed { get; set; }
		public bool IsDeleted { get; set; }
		public bool IsSpam { get; set; }
		public bool IsPinnedToAgent { get; set; }
		public DateTime? DateDeletedUtc { get; set; }
		public int? UserIdCustomer { get; set; }
		public DateTime? HoldStartAssignedUtc { get; set; }
		public DateTime? HoldStartComposeUtc { get; set; }
		public DateTime? HoldStartPinnedUtc { get; set; }
		public DateTime? HoldStartReadUtc { get; set; }
		public bool RequiresFollowUp { get; set; }
		public DateTime? DateFollowUpUtc { get; set; }
		public bool ShowInFollowUpView { get; set; }
		public bool AutoAssignOnFollowup { get; set; }
		public double? AverageSurveyRating { get; set; }
		public DateTime? DateClosedUtc { get; set; }
		public int? TicketCommentIdFollowUp { get; set; }

		public StGroups StGroups { get; set; }
		public StTicketPriorities TicketPriority { get; set; }
		public StTicketStatuses TicketStatus { get; set; }
		public StUsers User { get; set; }
		public StUsers UserIdCustomerNavigation { get; set; }
		public ICollection<StCustomDataFieldsInTickets> StCustomDataFieldsInTickets { get; set; }
		public ICollection<StSearchTokensInTickets> StSearchTokensInTickets { get; set; }
		public ICollection<StSurveyOfferedUserContext> StSurveyOfferedUserContext { get; set; }
		public ICollection<StTasks> StTasks { get; set; }
		public ICollection<StThreads> StThreads { get; set; }
		public ICollection<StTicketAttachments> StTicketAttachments { get; set; }
		public ICollection<StTicketComments> StTicketComments { get; set; }
		public ICollection<StTicketEmails> StTicketEmails { get; set; }
		public ICollection<StTicketEventLogs> StTicketEventLogs { get; set; }
		public ICollection<StTicketLinks> StTicketLinksTicket { get; set; }
		public ICollection<StTicketLinks> StTicketLinksTicketIdSecondaryNavigation { get; set; }
		public ICollection<StTicketMerges> StTicketMerges { get; set; }
		public ICollection<StTicketMessages> StTicketMessages { get; set; }
		public ICollection<StTicketTimings> StTicketTimings { get; set; }
	}
}
