using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StSmtpAccounts
    {
        public StSmtpAccounts()
        {
            StBrands = new HashSet<StBrands>();
            StDepartments = new HashSet<StDepartments>();
        }

        public int SmtpAccountId { get; set; }
        public string ServerName { get; set; }
        public int ServerPort { get; set; }
        public string LoginName { get; set; }
        public string LoginPassword { get; set; }
        public string FromAddress { get; set; }
        public string FromFriendlyName { get; set; }
        public bool UseAuthentication { get; set; }
        public bool UseSsl { get; set; }
        public string LoginPasswordEncrypted { get; set; }
        public string LoginPasswordSalt { get; set; }
        public bool UseTls { get; set; }
        public bool? AuthenticateSsl { get; set; }

        public ICollection<StBrands> StBrands { get; set; }
        public ICollection<StDepartments> StDepartments { get; set; }
    }
}
