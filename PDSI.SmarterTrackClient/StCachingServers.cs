using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StCachingServers
    {
        public int CachingServerId { get; set; }
        public string HostName { get; set; }
        public int Port { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime DateCreatedUtc { get; set; }
    }
}
