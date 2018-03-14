using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StSearchTokens
    {
        public StSearchTokens()
        {
            StSearchTokenStats = new HashSet<StSearchTokenStats>();
            StSearchTokensInCallLogs = new HashSet<StSearchTokensInCallLogs>();
            StSearchTokensInChats = new HashSet<StSearchTokensInChats>();
            StSearchTokensInKbarticles = new HashSet<StSearchTokensInKbarticles>();
            StSearchTokensInTasks = new HashSet<StSearchTokensInTasks>();
            StSearchTokensInThreads = new HashSet<StSearchTokensInThreads>();
            StSearchTokensInTickets = new HashSet<StSearchTokensInTickets>();
        }

        public int SearchTokenId { get; set; }
        public string TokenText { get; set; }

        public ICollection<StSearchTokenStats> StSearchTokenStats { get; set; }
        public ICollection<StSearchTokensInCallLogs> StSearchTokensInCallLogs { get; set; }
        public ICollection<StSearchTokensInChats> StSearchTokensInChats { get; set; }
        public ICollection<StSearchTokensInKbarticles> StSearchTokensInKbarticles { get; set; }
        public ICollection<StSearchTokensInTasks> StSearchTokensInTasks { get; set; }
        public ICollection<StSearchTokensInThreads> StSearchTokensInThreads { get; set; }
        public ICollection<StSearchTokensInTickets> StSearchTokensInTickets { get; set; }
    }
}
