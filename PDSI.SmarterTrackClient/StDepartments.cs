using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StDepartments
    {
        public StDepartments()
        {
            StBusinessHolidays = new HashSet<StBusinessHolidays>();
            StBusinessHours = new HashSet<StBusinessHours>();
            StCannedReplies = new HashSet<StCannedReplies>();
            StCustomDataFieldsForDepartments = new HashSet<StCustomDataFieldsForDepartments>();
            StDepartmentSettings = new HashSet<StDepartmentSettings>();
            StDepartmentsInChatImageConfigs = new HashSet<StDepartmentsInChatImageConfigs>();
            StGroups = new HashSet<StGroups>();
            StPopAccounts = new HashSet<StPopAccounts>();
        }

        public int DepartmentId { get; set; }
        public string DisplayName { get; set; }
        public int? FileDirectoryId { get; set; }
        public int? SmtpAccountId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsInternal { get; set; }
        public bool IsAutoResponderEnabled { get; set; }
        public int? AutoResponderId { get; set; }
        public string ChatWaitMessage { get; set; }
        public bool AutoCloseEnabled { get; set; }
        public int AutoCloseHours { get; set; }
        public bool AutoCloseSendEmailToClient { get; set; }
        public bool AutoDeleteEnabled { get; set; }
        public int AutoDeleteDays { get; set; }
        public int? CustomTemplateIdChat { get; set; }
        public int? CustomTemplateIdTicket { get; set; }
        public short? TicketsRequireRole { get; set; }
        public bool IsRestrictedToMemberAgents { get; set; }
        public int? BrandId { get; set; }
        public int? LanguageId { get; set; }
        public bool TicketRequireResolution { get; set; }
        public int? SurveyDefinitionIdafterChat { get; set; }
        public string PostChatText { get; set; }
        public int? SurveyDefinitionIdafterTicket { get; set; }
        public int? CustomTemplateIdCallLog { get; set; }
        public int AutoDeleteCallLogDays { get; set; }
        public bool AutoDeleteCallLogEnabled { get; set; }
        public bool TicketRequireClosedTasks { get; set; }
        public bool AutoLockEnabled { get; set; }
        public int AutoLockHours { get; set; }
        public int LiveChatRestriction { get; set; }
        public bool? UseBrandHolidays { get; set; }
        public bool? UseBrandHours { get; set; }

        public StAutoResponders AutoResponder { get; set; }
        public StBrands Brand { get; set; }
        public StCustomTemplates CustomTemplateIdCallLogNavigation { get; set; }
        public StCustomTemplates CustomTemplateIdChatNavigation { get; set; }
        public StCustomTemplates CustomTemplateIdTicketNavigation { get; set; }
        public StFileDirectories FileDirectory { get; set; }
        public StLanguages Language { get; set; }
        public StSmtpAccounts SmtpAccount { get; set; }
        public StSurveyDefinitions SurveyDefinitionIdafterChatNavigation { get; set; }
        public StSurveyDefinitions SurveyDefinitionIdafterTicketNavigation { get; set; }
        public StRoles TicketsRequireRoleNavigation { get; set; }
        public ICollection<StBusinessHolidays> StBusinessHolidays { get; set; }
        public ICollection<StBusinessHours> StBusinessHours { get; set; }
        public ICollection<StCannedReplies> StCannedReplies { get; set; }
        public ICollection<StCustomDataFieldsForDepartments> StCustomDataFieldsForDepartments { get; set; }
        public ICollection<StDepartmentSettings> StDepartmentSettings { get; set; }
        public ICollection<StDepartmentsInChatImageConfigs> StDepartmentsInChatImageConfigs { get; set; }
        public ICollection<StGroups> StGroups { get; set; }
        public ICollection<StPopAccounts> StPopAccounts { get; set; }
    }
}
