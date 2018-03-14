using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StEmailAddresses
    {
        public StEmailAddresses()
        {
            StTicketEventLogs = new HashSet<StTicketEventLogs>();
        }

        public int EmailAddressId { get; set; }
        public string Address { get; set; }

        public ICollection<StTicketEventLogs> StTicketEventLogs { get; set; }
    }
}
