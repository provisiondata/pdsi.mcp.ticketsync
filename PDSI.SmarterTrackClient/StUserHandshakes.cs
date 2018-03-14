using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StUserHandshakes
    {
        public string HandshakeToken { get; set; }
        public int HandshakeMethod { get; set; }
        public DateTime DateExpiresUtc { get; set; }
        public int UserId { get; set; }

        public StUsers User { get; set; }
    }
}
