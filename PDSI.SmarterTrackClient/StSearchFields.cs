using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StSearchFields
    {
        public StSearchFields()
        {
            StSearchFieldsInSearchTypes = new HashSet<StSearchFieldsInSearchTypes>();
            StSearchTokenStats = new HashSet<StSearchTokenStats>();
            StSearchTokensInCallLogs = new HashSet<StSearchTokensInCallLogs>();
            StSearchTokensInChats = new HashSet<StSearchTokensInChats>();
            StSearchTokensInKbarticles = new HashSet<StSearchTokensInKbarticles>();
            StSearchTokensInTasks = new HashSet<StSearchTokensInTasks>();
            StSearchTokensInThreads = new HashSet<StSearchTokensInThreads>();
            StSearchTokensInTickets = new HashSet<StSearchTokensInTickets>();
        }

        public int SearchFieldId { get; set; }
        public string EnglishName { get; set; }
        public string DisplayName { get; set; }
        public bool IsKbfield { get; set; }
        public bool IsTicketField { get; set; }
        public bool IsTicketCommentField { get; set; }
        public bool IsChatField { get; set; }
        public bool IsChatCommentField { get; set; }
        public bool IsTaskField { get; set; }
        public bool IsTaskCommentField { get; set; }
        public bool IsCallField { get; set; }
        public bool IsThreadField { get; set; }

        public ICollection<StSearchFieldsInSearchTypes> StSearchFieldsInSearchTypes { get; set; }
        public ICollection<StSearchTokenStats> StSearchTokenStats { get; set; }
        public ICollection<StSearchTokensInCallLogs> StSearchTokensInCallLogs { get; set; }
        public ICollection<StSearchTokensInChats> StSearchTokensInChats { get; set; }
        public ICollection<StSearchTokensInKbarticles> StSearchTokensInKbarticles { get; set; }
        public ICollection<StSearchTokensInTasks> StSearchTokensInTasks { get; set; }
        public ICollection<StSearchTokensInThreads> StSearchTokensInThreads { get; set; }
        public ICollection<StSearchTokensInTickets> StSearchTokensInTickets { get; set; }
    }
}
