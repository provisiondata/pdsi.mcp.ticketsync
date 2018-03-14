using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StSearchTokenStats
    {
        public int SearchTokenId { get; set; }
        public int SearchFieldId { get; set; }
        public DateTime? DateCalculatedUtc { get; set; }
        public double WeightFactor { get; set; }

        public StSearchFields SearchField { get; set; }
        public StSearchTokens SearchToken { get; set; }
    }
}
