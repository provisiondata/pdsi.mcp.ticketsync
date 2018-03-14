using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTicketEmails
    {
        public long TicketEmailId { get; set; }
        public int TicketId { get; set; }
        public string Email { get; set; }
        public string FriendlyName { get; set; }
        public string DomainName { get; set; }

        public StTickets Ticket { get; set; }
    }
}
