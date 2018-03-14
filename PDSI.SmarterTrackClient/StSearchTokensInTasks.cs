using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StSearchTokensInTasks
    {
        public int SearchTokenId { get; set; }
        public int SearchFieldId { get; set; }
        public int TaskId { get; set; }
        public int TokenCount { get; set; }

        public StSearchFields SearchField { get; set; }
        public StSearchTokens SearchToken { get; set; }
        public StTasks Task { get; set; }
    }
}
