using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StUserSettings
    {
        public int UserId { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }

        public StUsers User { get; set; }
    }
}
