using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StEventProfiles
    {
        public int EventProfileId { get; set; }
        public int? UserId { get; set; }
        public string Name { get; set; }
        public bool DoPopup { get; set; }
        public bool DoEmail { get; set; }
        public bool DoSms { get; set; }
        public bool DoMsn { get; set; }
        public string EmailAddress { get; set; }
        public string SmsAddress { get; set; }
        public string MsnAddress { get; set; }
        public bool IsDefaultProfile { get; set; }

        public StUsers User { get; set; }
    }
}
