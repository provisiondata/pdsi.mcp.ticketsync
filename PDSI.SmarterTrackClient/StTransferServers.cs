using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTransferServers
    {
        public int TransferServerId { get; set; }
        public string BaseUrl { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PasswordFormat { get; set; }
        public string PasswordSalt { get; set; }
        public string Name { get; set; }
    }
}
