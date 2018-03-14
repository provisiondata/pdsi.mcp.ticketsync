using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StServers
    {
        public int ServerId { get; set; }
        public string MachineName { get; set; }
        public string UniqueKey { get; set; }
        public DateTime DateLastHeartbeatUtc { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsActiveServer { get; set; }
        public string FilePath { get; set; }
        public DateTime? DateClusterSettingChangeUtc { get; set; }
        public string LicensingMode { get; set; }
    }
}
