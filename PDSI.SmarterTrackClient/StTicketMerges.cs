using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTicketMerges
    {
        public string TicketNumber { get; set; }
        public int TicketId { get; set; }

        public StTickets Ticket { get; set; }
    }
}
