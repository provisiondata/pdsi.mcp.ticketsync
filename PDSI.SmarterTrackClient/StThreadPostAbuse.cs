using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StThreadPostAbuse
    {
        public int ThreadPostId { get; set; }
        public int UserId { get; set; }
        public short TypeOfAbuse { get; set; }
        public short ModerationStatus { get; set; }

        public StThreadPosts ThreadPost { get; set; }
        public StUsers User { get; set; }
    }
}
