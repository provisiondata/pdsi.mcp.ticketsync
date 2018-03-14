using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StThreadCommentAbuse
    {
        public int ThreadCommentId { get; set; }
        public int UserId { get; set; }
        public short TypeOfAbuse { get; set; }
        public short ModerationStatus { get; set; }

        public StThreadComments ThreadComment { get; set; }
        public StUsers User { get; set; }
    }
}
