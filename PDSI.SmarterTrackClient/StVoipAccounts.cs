using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StVoipAccounts
    {
        public int VoipAccountId { get; set; }
        public string VoipAccountGuid { get; set; }
        public int DepartmentId { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public string LoginUsername { get; set; }
        public string LoginPassword { get; set; }
        public string SipServer { get; set; }
        public string SipDomain { get; set; }
        public int? SipPort { get; set; }
        public string SipAuthName { get; set; }
        public string StunServer { get; set; }
        public int? StunPort { get; set; }
        public int? MaxPhoneLines { get; set; }
        public int? PublicCountryCode { get; set; }
        public string PublicPhoneNumber { get; set; }
        public string PublicExtension { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsBusy { get; set; }
        public bool UseSdp { get; set; }
        public string SipOutboundProxy { get; set; }
        public int? SipOutboundProxyPort { get; set; }
        public int MinCallLogLength { get; set; }

        public StGroups StGroups { get; set; }
        public StUsers User { get; set; }
    }
}
