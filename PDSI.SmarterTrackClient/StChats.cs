using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StChats
    {
        public StChats()
        {
            StChatAttachments = new HashSet<StChatAttachments>();
            StChatComments = new HashSet<StChatComments>();
            StChatEventLogs = new HashSet<StChatEventLogs>();
            StChatMessages = new HashSet<StChatMessages>();
            StCustomDataFieldsInChats = new HashSet<StCustomDataFieldsInChats>();
            StSearchTokensInChats = new HashSet<StSearchTokensInChats>();
            StSurveyOfferedUserContext = new HashSet<StSurveyOfferedUserContext>();
            StTasks = new HashSet<StTasks>();
            StTicketLinks = new HashSet<StTicketLinks>();
        }

        public int ChatId { get; set; }
        public int DepartmentId { get; set; }
        public int GroupId { get; set; }
        public int? UserId { get; set; }
        public int? CustomerUserId { get; set; }
        public string ChatGuid { get; set; }
        public string ChatNumber { get; set; }
        public DateTime DateStartedUtc { get; set; }
        public DateTime? DateQueuedUtc { get; set; }
        public DateTime? DateEndedUtc { get; set; }
        public DateTime? DateDeletedUtc { get; set; }
        public int? SessionLengthInSeconds { get; set; }
        public int? AverageIdleSeconds { get; set; }
        public int? LongestIdleSeconds { get; set; }
        public int? InitialResponseSeconds { get; set; }
        public int QueueWaitSeconds { get; set; }
        public string CustomerIp { get; set; }
        public string CustomerDisplayName { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsIndexed { get; set; }
        public int MessageCountIn { get; set; }
        public int MessageCountOut { get; set; }
        public string CustomerEmailAddress { get; set; }
        public string CustomerLanguage { get; set; }
        public long? UserTrackingCookieId { get; set; }
        public bool IsFromAgentInvite { get; set; }
        public DateTime? DateIdleStartedUtc { get; set; }
        public bool IsLastMessageInbound { get; set; }
        public string TrackingId { get; set; }
        public string InitialQuestion { get; set; }
        public double? AverageSurveyRating { get; set; }
        public string CustomerTranslationChoice { get; set; }

        public StGroups StGroups { get; set; }
        public StUsers User { get; set; }
        public StUserTrackingCookies UserTrackingCookie { get; set; }
        public ICollection<StChatAttachments> StChatAttachments { get; set; }
        public ICollection<StChatComments> StChatComments { get; set; }
        public ICollection<StChatEventLogs> StChatEventLogs { get; set; }
        public ICollection<StChatMessages> StChatMessages { get; set; }
        public ICollection<StCustomDataFieldsInChats> StCustomDataFieldsInChats { get; set; }
        public ICollection<StSearchTokensInChats> StSearchTokensInChats { get; set; }
        public ICollection<StSurveyOfferedUserContext> StSurveyOfferedUserContext { get; set; }
        public ICollection<StTasks> StTasks { get; set; }
        public ICollection<StTicketLinks> StTicketLinks { get; set; }
    }
}
