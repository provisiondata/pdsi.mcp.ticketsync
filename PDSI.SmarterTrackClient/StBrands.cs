using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StBrands
    {
        public StBrands()
        {
            StAgentChatPermissions = new HashSet<StAgentChatPermissions>();
            StBusinessHolidays = new HashSet<StBusinessHolidays>();
            StBusinessHours = new HashSet<StBusinessHours>();
            StCustomDataFieldsForBrands = new HashSet<StCustomDataFieldsForBrands>();
            StDepartments = new HashSet<StDepartments>();
            StKbArticlesBrands = new HashSet<StKbArticlesBrands>();
            StNewsItemsBrands = new HashSet<StNewsItemsBrands>();
            StRssFeeds = new HashSet<StRssFeeds>();
            StSignatures = new HashSet<StSignatures>();
            StThreadTags = new HashSet<StThreadTags>();
            StThreads = new HashSet<StThreads>();
            StWebCustomActions = new HashSet<StWebCustomActions>();
            StWhosOnFilter = new HashSet<StWhosOnFilter>();
        }

        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string HostHeaderValue { get; set; }
        public bool IsDefaultBrand { get; set; }
        public int? PublicSiteLogoFileId { get; set; }
        public string PublicSiteLogoNavigateUrl { get; set; }
        public bool PublicSiteLogoEnabled { get; set; }
        public int? SmtpAccountId { get; set; }
        public bool? DisplayPortalTrafficForWhosOn { get; set; }
        public string RelatedUrls { get; set; }
        public string PortalColor { get; set; }
        public string WelcomeMessage { get; set; }
        public string CustomCss { get; set; }
        public int? VoipCountryCode { get; set; }
        public string VoipPhoneNumber { get; set; }
        public int VoipMaxLinesPerAgent { get; set; }
        public int VoipMaxChatsBeforeUnavailable { get; set; }
        public int? FileIdVoipIcon { get; set; }
        public int? FileIdVoipRingTone { get; set; }
        public bool? VoipAutoRecordCalls { get; set; }
        public int ViewThreadRestriction { get; set; }
        public int NewThreadRestriction { get; set; }
        public bool? CommunityEnabled { get; set; }
        public int ChatLinkImageConfig { get; set; }
        public bool? AvatarUploadsRequireApproval { get; set; }
        public bool? DisplayLiveChat { get; set; }
        public bool? DisplayOptionToSendTicketListByEmail { get; set; }
        public bool? EnableGravatarSupport { get; set; }
        public bool? EnablePortalLogin { get; set; }
        public bool? EnableRegisteredUsersToChangeDisplayName { get; set; }
        public bool? EnableRegisteredUsersToChangeEmailAddress { get; set; }
        public bool? EnableRegisteredUsersToChangePasswords { get; set; }
        public bool? EnableRegisteredUsersToChangePhoneNumber { get; set; }
        public bool? EnableRegisteredUsersToUploadAvatars { get; set; }
        public bool? EnableRegistration { get; set; }
        public bool? EnableSocialSharingLinks { get; set; }
        public bool? NewFeedbackStartsOutModerated { get; set; }
        public int AddFeedbackRestriction { get; set; }
        public int StartChatRestriction { get; set; }
        public int ViewKbfeedbackRestriction { get; set; }
        public int ViewNewsRestriction { get; set; }
        public string DepartmentSelectionTextForChats { get; set; }
        public string DepartmentSelectionTextForTickets { get; set; }
        public int ViewPortalTicketsRestriction { get; set; }
        public bool? EnableKbVoting { get; set; }
        public string AdditionalFooterMessage { get; set; }
        public string GoogleAnalyticsTrackingId { get; set; }
        public int? FileIdFavicon { get; set; }
        public string DefaultFont { get; set; }

        public StFiles FileIdFaviconNavigation { get; set; }
        public StFiles FileIdVoipIconNavigation { get; set; }
        public StFiles FileIdVoipRingToneNavigation { get; set; }
        public StFiles PublicSiteLogoFile { get; set; }
        public StSmtpAccounts SmtpAccount { get; set; }
        public ICollection<StAgentChatPermissions> StAgentChatPermissions { get; set; }
        public ICollection<StBusinessHolidays> StBusinessHolidays { get; set; }
        public ICollection<StBusinessHours> StBusinessHours { get; set; }
        public ICollection<StCustomDataFieldsForBrands> StCustomDataFieldsForBrands { get; set; }
        public ICollection<StDepartments> StDepartments { get; set; }
        public ICollection<StKbArticlesBrands> StKbArticlesBrands { get; set; }
        public ICollection<StNewsItemsBrands> StNewsItemsBrands { get; set; }
        public ICollection<StRssFeeds> StRssFeeds { get; set; }
        public ICollection<StSignatures> StSignatures { get; set; }
        public ICollection<StThreadTags> StThreadTags { get; set; }
        public ICollection<StThreads> StThreads { get; set; }
        public ICollection<StWebCustomActions> StWebCustomActions { get; set; }
        public ICollection<StWhosOnFilter> StWhosOnFilter { get; set; }
    }
}
