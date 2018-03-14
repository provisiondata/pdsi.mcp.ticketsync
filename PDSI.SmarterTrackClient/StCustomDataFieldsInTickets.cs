using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StCustomDataFieldsInTickets
    {
        public int TicketId { get; set; }
        public int CustomFieldId { get; set; }
        public string DataContent { get; set; }

        public StCustomDataFields CustomField { get; set; }
        public StTickets Ticket { get; set; }
    }
}
