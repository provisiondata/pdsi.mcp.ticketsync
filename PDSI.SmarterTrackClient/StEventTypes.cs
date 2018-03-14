using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StEventTypes
    {
        public StEventTypes()
        {
            StCallLogEventLogs = new HashSet<StCallLogEventLogs>();
            StCannedReplyEventLogs = new HashSet<StCannedReplyEventLogs>();
            StChatEventLogs = new HashSet<StChatEventLogs>();
            StGeneralEventLogs = new HashSet<StGeneralEventLogs>();
            StKbEventLogs = new HashSet<StKbEventLogs>();
            StNewsEventLogs = new HashSet<StNewsEventLogs>();
            StTaskEventLogs = new HashSet<StTaskEventLogs>();
            StTicketEventLogs = new HashSet<StTicketEventLogs>();
            StTimeEstimates = new HashSet<StTimeEstimates>();
            StUserEventLogs = new HashSet<StUserEventLogs>();
        }

        public int EventTypeId { get; set; }
        public string EnglishName { get; set; }
        public string DisplayName { get; set; }

        public ICollection<StCallLogEventLogs> StCallLogEventLogs { get; set; }
        public ICollection<StCannedReplyEventLogs> StCannedReplyEventLogs { get; set; }
        public ICollection<StChatEventLogs> StChatEventLogs { get; set; }
        public ICollection<StGeneralEventLogs> StGeneralEventLogs { get; set; }
        public ICollection<StKbEventLogs> StKbEventLogs { get; set; }
        public ICollection<StNewsEventLogs> StNewsEventLogs { get; set; }
        public ICollection<StTaskEventLogs> StTaskEventLogs { get; set; }
        public ICollection<StTicketEventLogs> StTicketEventLogs { get; set; }
        public ICollection<StTimeEstimates> StTimeEstimates { get; set; }
        public ICollection<StUserEventLogs> StUserEventLogs { get; set; }
    }
}
