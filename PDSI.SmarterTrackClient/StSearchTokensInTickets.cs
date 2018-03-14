using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StSearchTokensInTickets
    {
        public int SearchTokenId { get; set; }
        public int SearchFieldId { get; set; }
        public int TicketId { get; set; }
        public int TokenCount { get; set; }

        public StSearchFields SearchField { get; set; }
        public StSearchTokens SearchToken { get; set; }
        public StTickets Ticket { get; set; }
    }
}
