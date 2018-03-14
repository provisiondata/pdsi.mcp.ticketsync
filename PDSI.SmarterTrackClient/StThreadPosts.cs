using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StThreadPosts
    {
        public StThreadPosts()
        {
            StThreadComments = new HashSet<StThreadComments>();
            StThreadPostAbuse = new HashSet<StThreadPostAbuse>();
            StThreadPostAttachments = new HashSet<StThreadPostAttachments>();
            StThreadPostScores = new HashSet<StThreadPostScores>();
        }

        public int ThreadPostId { get; set; }
        public int ThreadId { get; set; }
        public int? UserId { get; set; }
        public int Score { get; set; }
        public int ScoreCount { get; set; }
        public bool? Visible { get; set; }
        public bool NeedsModeration { get; set; }
        public bool IsAnswer { get; set; }
        public bool IsOriginalPost { get; set; }
        public bool IsHelpfulToCreator { get; set; }
        public bool IsEmployeePost { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string BodyHtml { get; set; }
        public string Ipaddress { get; set; }

        public StThreads Thread { get; set; }
        public StUsers User { get; set; }
        public ICollection<StThreadComments> StThreadComments { get; set; }
        public ICollection<StThreadPostAbuse> StThreadPostAbuse { get; set; }
        public ICollection<StThreadPostAttachments> StThreadPostAttachments { get; set; }
        public ICollection<StThreadPostScores> StThreadPostScores { get; set; }
    }
}
