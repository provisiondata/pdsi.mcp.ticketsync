using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StThreadPostScores
    {
        public int ThreadPostId { get; set; }
        public int UserId { get; set; }
        public int Score { get; set; }

        public StThreadPosts ThreadPost { get; set; }
        public StUsers User { get; set; }
    }
}
