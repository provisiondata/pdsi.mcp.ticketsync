using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTicketLinks
    {
        public int TicketLinkId { get; set; }
        public int TicketId { get; set; }
        public int? TicketIdSecondary { get; set; }
        public int? ChatId { get; set; }
        public int? CallLogId { get; set; }

        public StCallLogs CallLog { get; set; }
        public StChats Chat { get; set; }
        public StTickets Ticket { get; set; }
        public StTickets TicketIdSecondaryNavigation { get; set; }
    }
}
