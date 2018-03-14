using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StThreadComments
    {
        public StThreadComments()
        {
            StThreadCommentAbuse = new HashSet<StThreadCommentAbuse>();
        }

        public int ThreadCommentId { get; set; }
        public int ThreadPostId { get; set; }
        public int? UserId { get; set; }
        public bool? Visible { get; set; }
        public bool NeedsModeration { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string BodyText { get; set; }
        public string Ipaddress { get; set; }

        public StThreadPosts ThreadPost { get; set; }
        public StUsers User { get; set; }
        public ICollection<StThreadCommentAbuse> StThreadCommentAbuse { get; set; }
    }
}
