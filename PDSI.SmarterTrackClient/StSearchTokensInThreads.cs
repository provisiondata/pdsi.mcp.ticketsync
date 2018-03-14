using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StSearchTokensInThreads
    {
        public int SearchTokenId { get; set; }
        public int SearchFieldId { get; set; }
        public int ThreadId { get; set; }
        public int TokenCount { get; set; }

        public StSearchFields SearchField { get; set; }
        public StSearchTokens SearchToken { get; set; }
        public StThreads Thread { get; set; }
    }
}
