using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StPopAccounts
    {
        public StPopAccounts()
        {
            StPopAccountUids = new HashSet<StPopAccountUids>();
        }

        public int PopAccountId { get; set; }
        public int DepartmentId { get; set; }
        public string ServerName { get; set; }
        public int ServerPort { get; set; }
        public string LoginName { get; set; }
        public string LoginPassword { get; set; }
        public int ImportFrequencyMinutes { get; set; }
        public bool IsEnabled { get; set; }
        public bool UseSsl { get; set; }
        public string LoginPasswordEncrypted { get; set; }
        public string LoginPasswordSalt { get; set; }
        public bool UseTls { get; set; }
        public bool LeaveMailOnServer { get; set; }
        public int NewTicketRestriction { get; set; }
        public bool? AuthenticateSsl { get; set; }
        public string EmailAddress { get; set; }

        public StDepartments Department { get; set; }
        public ICollection<StPopAccountUids> StPopAccountUids { get; set; }
    }
}
