using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StGroups
    {
        public StGroups()
        {
            StAgentChatPermissions = new HashSet<StAgentChatPermissions>();
            StCallLogEventLogsOld = new HashSet<StCallLogEventLogs>();
            StCallLogEventLogsStGroups = new HashSet<StCallLogEventLogs>();
            StCallLogs = new HashSet<StCallLogs>();
            StCannedReplyEventLogs = new HashSet<StCannedReplyEventLogs>();
            StChatChannelPermissions = new HashSet<StChatChannelPermissions>();
            StChatEventLogsOld = new HashSet<StChatEventLogs>();
            StChatEventLogsStGroups = new HashSet<StChatEventLogs>();
            StChats = new HashSet<StChats>();
            StCustomDataFieldsForGroups = new HashSet<StCustomDataFieldsForGroups>();
            StGeneralEventLogs = new HashSet<StGeneralEventLogs>();
            StRebalanceRules = new HashSet<StRebalanceRules>();
            StSignatures = new HashSet<StSignatures>();
            StTicketEventLogsOld = new HashSet<StTicketEventLogs>();
            StTicketEventLogsStGroups = new HashSet<StTicketEventLogs>();
            StTicketTimings = new HashSet<StTicketTimings>();
            StTickets = new HashSet<StTickets>();
            StTimeEstimates = new HashSet<StTimeEstimates>();
            StUserEventLogs = new HashSet<StUserEventLogs>();
            StUserTimings = new HashSet<StUserTimings>();
            StUsersInGroups = new HashSet<StUsersInGroups>();
            StVoipAccounts = new HashSet<StVoipAccounts>();
        }

        public int DepartmentId { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsFrontLine { get; set; }
        public bool IsInternal { get; set; }
        public short AlertOption { get; set; }
        public string AlertAddress { get; set; }
        public int? VoipExtension { get; set; }

        public StDepartments Department { get; set; }
        public ICollection<StAgentChatPermissions> StAgentChatPermissions { get; set; }
        public ICollection<StCallLogEventLogs> StCallLogEventLogsOld { get; set; }
        public ICollection<StCallLogEventLogs> StCallLogEventLogsStGroups { get; set; }
        public ICollection<StCallLogs> StCallLogs { get; set; }
        public ICollection<StCannedReplyEventLogs> StCannedReplyEventLogs { get; set; }
        public ICollection<StChatChannelPermissions> StChatChannelPermissions { get; set; }
        public ICollection<StChatEventLogs> StChatEventLogsOld { get; set; }
        public ICollection<StChatEventLogs> StChatEventLogsStGroups { get; set; }
        public ICollection<StChats> StChats { get; set; }
        public ICollection<StCustomDataFieldsForGroups> StCustomDataFieldsForGroups { get; set; }
        public ICollection<StGeneralEventLogs> StGeneralEventLogs { get; set; }
        public ICollection<StRebalanceRules> StRebalanceRules { get; set; }
        public ICollection<StSignatures> StSignatures { get; set; }
        public ICollection<StTicketEventLogs> StTicketEventLogsOld { get; set; }
        public ICollection<StTicketEventLogs> StTicketEventLogsStGroups { get; set; }
        public ICollection<StTicketTimings> StTicketTimings { get; set; }
        public ICollection<StTickets> StTickets { get; set; }
        public ICollection<StTimeEstimates> StTimeEstimates { get; set; }
        public ICollection<StUserEventLogs> StUserEventLogs { get; set; }
        public ICollection<StUserTimings> StUserTimings { get; set; }
        public ICollection<StUsersInGroups> StUsersInGroups { get; set; }
        public ICollection<StVoipAccounts> StVoipAccounts { get; set; }
    }
}
