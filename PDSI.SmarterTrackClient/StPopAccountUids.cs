using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StPopAccountUids
    {
        public long PopAccountUidId { get; set; }
        public int PopAccountId { get; set; }
        public string Uid { get; set; }

        public StPopAccounts PopAccount { get; set; }
    }
}
