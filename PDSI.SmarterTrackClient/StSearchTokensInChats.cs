using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StSearchTokensInChats
    {
        public int SearchTokenId { get; set; }
        public int SearchFieldId { get; set; }
        public int ChatId { get; set; }
        public int TokenCount { get; set; }

        public StChats Chat { get; set; }
        public StSearchFields SearchField { get; set; }
        public StSearchTokens SearchToken { get; set; }
    }
}
