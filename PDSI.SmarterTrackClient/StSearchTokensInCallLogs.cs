using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StSearchTokensInCallLogs
    {
        public int SearchTokenId { get; set; }
        public int SearchFieldId { get; set; }
        public int CallLogId { get; set; }
        public int TokenCount { get; set; }

        public StCallLogs CallLog { get; set; }
        public StSearchFields SearchField { get; set; }
        public StSearchTokens SearchToken { get; set; }
    }
}
