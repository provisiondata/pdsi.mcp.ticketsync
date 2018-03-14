using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StUsers
    {
        public StUsers()
        {
            StAgentChatParticipants = new HashSet<StAgentChatParticipants>();
            StCallLogAttachments = new HashSet<StCallLogAttachments>();
            StCallLogEventLogsOldUser = new HashSet<StCallLogEventLogs>();
            StCallLogEventLogsUser = new HashSet<StCallLogEventLogs>();
            StCallLogEventLogsUserIdtakingActionNavigation = new HashSet<StCallLogEventLogs>();
            StCallLogs = new HashSet<StCallLogs>();
            StCannedReplies = new HashSet<StCannedReplies>();
            StCannedReplyEventLogs = new HashSet<StCannedReplyEventLogs>();
            StChatAttachments = new HashSet<StChatAttachments>();
            StChatChannelEventLogsUser = new HashSet<StChatChannelEventLogs>();
            StChatChannelEventLogsUserIdtakingActionNavigation = new HashSet<StChatChannelEventLogs>();
            StChatChannelInvitesUserIdFromNavigation = new HashSet<StChatChannelInvites>();
            StChatChannelInvitesUserIdToNavigation = new HashSet<StChatChannelInvites>();
            StChatChannelMessages = new HashSet<StChatChannelMessages>();
            StChatChannelPermissions = new HashSet<StChatChannelPermissions>();
            StChatComments = new HashSet<StChatComments>();
            StChatEventLogsOldUser = new HashSet<StChatEventLogs>();
            StChatEventLogsUser = new HashSet<StChatEventLogs>();
            StChatMessages = new HashSet<StChatMessages>();
            StChats = new HashSet<StChats>();
            StConversationAbuseUserIdreportedNavigation = new HashSet<StConversationAbuse>();
            StConversationAbuseUserIdreportingNavigation = new HashSet<StConversationAbuse>();
            StConversationMessagesUserIdFromNavigation = new HashSet<StConversationMessages>();
            StConversationMessagesUserIdToNavigation = new HashSet<StConversationMessages>();
            StConversationsUserId1Navigation = new HashSet<StConversations>();
            StConversationsUserId2Navigation = new HashSet<StConversations>();
            StCustomDataFieldsForUsers = new HashSet<StCustomDataFieldsForUsers>();
            StCustomReports = new HashSet<StCustomReports>();
            StEventGroups = new HashSet<StEventGroups>();
            StEventProfiles = new HashSet<StEventProfiles>();
            StEventReminders = new HashSet<StEventReminders>();
            StFavoriteReports = new HashSet<StFavoriteReports>();
            StGeneralEventLogsUser = new HashSet<StGeneralEventLogs>();
            StGeneralEventLogsUserIdtakingActionNavigation = new HashSet<StGeneralEventLogs>();
            StKbAgentComments = new HashSet<StKbAgentComments>();
            StKbArticleCommentAbuse = new HashSet<StKbArticleCommentAbuse>();
            StKbArticleComments = new HashSet<StKbArticleComments>();
            StKbArticles = new HashSet<StKbArticles>();
            StKbEventLogs = new HashSet<StKbEventLogs>();
            StNewsEventLogs = new HashSet<StNewsEventLogs>();
            StOrganizationFilters = new HashSet<StOrganizationFilters>();
            StRecurringTasks = new HashSet<StRecurringTasks>();
            StSurveyOfferedUserContext = new HashSet<StSurveyOfferedUserContext>();
            StTaskComments = new HashSet<StTaskComments>();
            StTaskEventLogsOldUser = new HashSet<StTaskEventLogs>();
            StTaskEventLogsUser = new HashSet<StTaskEventLogs>();
            StTaskEventLogsUserIdtakingActionNavigation = new HashSet<StTaskEventLogs>();
            StTasks = new HashSet<StTasks>();
            StThreadCommentAbuse = new HashSet<StThreadCommentAbuse>();
            StThreadComments = new HashSet<StThreadComments>();
            StThreadPostAbuse = new HashSet<StThreadPostAbuse>();
            StThreadPostScores = new HashSet<StThreadPostScores>();
            StThreadPosts = new HashSet<StThreadPosts>();
            StThreadUserFlags = new HashSet<StThreadUserFlags>();
            StThreads = new HashSet<StThreads>();
            StTicketAttachments = new HashSet<StTicketAttachments>();
            StTicketComments = new HashSet<StTicketComments>();
            StTicketEventLogsOldUser = new HashSet<StTicketEventLogs>();
            StTicketEventLogsUser = new HashSet<StTicketEventLogs>();
            StTicketEventLogsUserIdtakingActionNavigation = new HashSet<StTicketEventLogs>();
            StTicketMessages = new HashSet<StTicketMessages>();
            StTicketTimings = new HashSet<StTicketTimings>();
            StTicketsUser = new HashSet<StTickets>();
            StTicketsUserIdCustomerNavigation = new HashSet<StTickets>();
            StUserAbuseUserIdreportedNavigation = new HashSet<StUserAbuse>();
            StUserAbuseUserIdreportingNavigation = new HashSet<StUserAbuse>();
            StUserCommentsUser = new HashSet<StUserComments>();
            StUserCommentsUserIdFromNavigation = new HashSet<StUserComments>();
            StUserEventLogsUser = new HashSet<StUserEventLogs>();
            StUserEventLogsUserIdtakingActionNavigation = new HashSet<StUserEventLogs>();
            StUserHandshakes = new HashSet<StUserHandshakes>();
            StUserSettings = new HashSet<StUserSettings>();
            StUserTimings = new HashSet<StUserTimings>();
            StUserTrackingCookies = new HashSet<StUserTrackingCookies>();
            StUserWebSessions = new HashSet<StUserWebSessions>();
            StUsersInGroups = new HashSet<StUsersInGroups>();
            StUsersInRebalanceRules = new HashSet<StUsersInRebalanceRules>();
            StUsersInRoles = new HashSet<StUsersInRoles>();
            StVoipAccounts = new HashSet<StVoipAccounts>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string LoweredUserName { get; set; }
        public string Email { get; set; }
        public string LoweredEmail { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public int PasswordFormat { get; set; }
        public string PasswordSalt { get; set; }
        public int AuthenticationType { get; set; }
        public string AuthenticationDomain { get; set; }
        public string Language { get; set; }
        public int? TimeZone { get; set; }
        public int? FileIdAvatar { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public DateTime DateLastLoginUtc { get; set; }
        public int? FileDirectoryId { get; set; }
        public double? HourlyPayRate { get; set; }
        public bool IsAvatarApproved { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsEmailVerified { get; set; }
        public bool IsLockedOut { get; set; }
        public bool IsPrimaryAdmin { get; set; }
        public bool IsQueue { get; set; }
        public double? AverageSurveyRating { get; set; }
        public int AvatarSource { get; set; }
        public int CommunityPostCount { get; set; }
        public bool IsModerated { get; set; }
        public string IpAddressCreated { get; set; }

        public StFileDirectories FileDirectory { get; set; }
        public StFiles FileIdAvatarNavigation { get; set; }
        public ICollection<StAgentChatParticipants> StAgentChatParticipants { get; set; }
        public ICollection<StCallLogAttachments> StCallLogAttachments { get; set; }
        public ICollection<StCallLogEventLogs> StCallLogEventLogsOldUser { get; set; }
        public ICollection<StCallLogEventLogs> StCallLogEventLogsUser { get; set; }
        public ICollection<StCallLogEventLogs> StCallLogEventLogsUserIdtakingActionNavigation { get; set; }
        public ICollection<StCallLogs> StCallLogs { get; set; }
        public ICollection<StCannedReplies> StCannedReplies { get; set; }
        public ICollection<StCannedReplyEventLogs> StCannedReplyEventLogs { get; set; }
        public ICollection<StChatAttachments> StChatAttachments { get; set; }
        public ICollection<StChatChannelEventLogs> StChatChannelEventLogsUser { get; set; }
        public ICollection<StChatChannelEventLogs> StChatChannelEventLogsUserIdtakingActionNavigation { get; set; }
        public ICollection<StChatChannelInvites> StChatChannelInvitesUserIdFromNavigation { get; set; }
        public ICollection<StChatChannelInvites> StChatChannelInvitesUserIdToNavigation { get; set; }
        public ICollection<StChatChannelMessages> StChatChannelMessages { get; set; }
        public ICollection<StChatChannelPermissions> StChatChannelPermissions { get; set; }
        public ICollection<StChatComments> StChatComments { get; set; }
        public ICollection<StChatEventLogs> StChatEventLogsOldUser { get; set; }
        public ICollection<StChatEventLogs> StChatEventLogsUser { get; set; }
        public ICollection<StChatMessages> StChatMessages { get; set; }
        public ICollection<StChats> StChats { get; set; }
        public ICollection<StConversationAbuse> StConversationAbuseUserIdreportedNavigation { get; set; }
        public ICollection<StConversationAbuse> StConversationAbuseUserIdreportingNavigation { get; set; }
        public ICollection<StConversationMessages> StConversationMessagesUserIdFromNavigation { get; set; }
        public ICollection<StConversationMessages> StConversationMessagesUserIdToNavigation { get; set; }
        public ICollection<StConversations> StConversationsUserId1Navigation { get; set; }
        public ICollection<StConversations> StConversationsUserId2Navigation { get; set; }
        public ICollection<StCustomDataFieldsForUsers> StCustomDataFieldsForUsers { get; set; }
        public ICollection<StCustomReports> StCustomReports { get; set; }
        public ICollection<StEventGroups> StEventGroups { get; set; }
        public ICollection<StEventProfiles> StEventProfiles { get; set; }
        public ICollection<StEventReminders> StEventReminders { get; set; }
        public ICollection<StFavoriteReports> StFavoriteReports { get; set; }
        public ICollection<StGeneralEventLogs> StGeneralEventLogsUser { get; set; }
        public ICollection<StGeneralEventLogs> StGeneralEventLogsUserIdtakingActionNavigation { get; set; }
        public ICollection<StKbAgentComments> StKbAgentComments { get; set; }
        public ICollection<StKbArticleCommentAbuse> StKbArticleCommentAbuse { get; set; }
        public ICollection<StKbArticleComments> StKbArticleComments { get; set; }
        public ICollection<StKbArticles> StKbArticles { get; set; }
        public ICollection<StKbEventLogs> StKbEventLogs { get; set; }
        public ICollection<StNewsEventLogs> StNewsEventLogs { get; set; }
        public ICollection<StOrganizationFilters> StOrganizationFilters { get; set; }
        public ICollection<StRecurringTasks> StRecurringTasks { get; set; }
        public ICollection<StSurveyOfferedUserContext> StSurveyOfferedUserContext { get; set; }
        public ICollection<StTaskComments> StTaskComments { get; set; }
        public ICollection<StTaskEventLogs> StTaskEventLogsOldUser { get; set; }
        public ICollection<StTaskEventLogs> StTaskEventLogsUser { get; set; }
        public ICollection<StTaskEventLogs> StTaskEventLogsUserIdtakingActionNavigation { get; set; }
        public ICollection<StTasks> StTasks { get; set; }
        public ICollection<StThreadCommentAbuse> StThreadCommentAbuse { get; set; }
        public ICollection<StThreadComments> StThreadComments { get; set; }
        public ICollection<StThreadPostAbuse> StThreadPostAbuse { get; set; }
        public ICollection<StThreadPostScores> StThreadPostScores { get; set; }
        public ICollection<StThreadPosts> StThreadPosts { get; set; }
        public ICollection<StThreadUserFlags> StThreadUserFlags { get; set; }
        public ICollection<StThreads> StThreads { get; set; }
        public ICollection<StTicketAttachments> StTicketAttachments { get; set; }
        public ICollection<StTicketComments> StTicketComments { get; set; }
        public ICollection<StTicketEventLogs> StTicketEventLogsOldUser { get; set; }
        public ICollection<StTicketEventLogs> StTicketEventLogsUser { get; set; }
        public ICollection<StTicketEventLogs> StTicketEventLogsUserIdtakingActionNavigation { get; set; }
        public ICollection<StTicketMessages> StTicketMessages { get; set; }
        public ICollection<StTicketTimings> StTicketTimings { get; set; }
        public ICollection<StTickets> StTicketsUser { get; set; }
        public ICollection<StTickets> StTicketsUserIdCustomerNavigation { get; set; }
        public ICollection<StUserAbuse> StUserAbuseUserIdreportedNavigation { get; set; }
        public ICollection<StUserAbuse> StUserAbuseUserIdreportingNavigation { get; set; }
        public ICollection<StUserComments> StUserCommentsUser { get; set; }
        public ICollection<StUserComments> StUserCommentsUserIdFromNavigation { get; set; }
        public ICollection<StUserEventLogs> StUserEventLogsUser { get; set; }
        public ICollection<StUserEventLogs> StUserEventLogsUserIdtakingActionNavigation { get; set; }
        public ICollection<StUserHandshakes> StUserHandshakes { get; set; }
        public ICollection<StUserSettings> StUserSettings { get; set; }
        public ICollection<StUserTimings> StUserTimings { get; set; }
        public ICollection<StUserTrackingCookies> StUserTrackingCookies { get; set; }
        public ICollection<StUserWebSessions> StUserWebSessions { get; set; }
        public ICollection<StUsersInGroups> StUsersInGroups { get; set; }
        public ICollection<StUsersInRebalanceRules> StUsersInRebalanceRules { get; set; }
        public ICollection<StUsersInRoles> StUsersInRoles { get; set; }
        public ICollection<StVoipAccounts> StVoipAccounts { get; set; }
    }
}
