using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StSearchTokensInKbarticles
    {
        public int SearchTokenId { get; set; }
        public int SearchFieldId { get; set; }
        public int ArticleId { get; set; }
        public int TokenCount { get; set; }

        public StKbArticles Article { get; set; }
        public StSearchFields SearchField { get; set; }
        public StSearchTokens SearchToken { get; set; }
    }
}
