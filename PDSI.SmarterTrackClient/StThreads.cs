using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StThreads
    {
        public StThreads()
        {
            StSearchTokensInThreads = new HashSet<StSearchTokensInThreads>();
            StThreadPosts = new HashSet<StThreadPosts>();
            StThreadTagsInThreads = new HashSet<StThreadTagsInThreads>();
            StThreadUserFlags = new HashSet<StThreadUserFlags>();
        }

        public int ThreadId { get; set; }
        public int? UserId { get; set; }
        public int BrandId { get; set; }
        public int Score { get; set; }
        public int ScoreCount { get; set; }
        public short CategoryType { get; set; }
        public bool HasAnswer { get; set; }
        public bool? Visible { get; set; }
        public bool IsIndexed { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public DateTime DateLastPostUtc { get; set; }
        public string Subject { get; set; }
        public int? TicketId { get; set; }
        public short Status { get; set; }
        public DateTime? DateLastActivityUtc { get; set; }
        public DateTime? DateLastStatusChangeUtc { get; set; }
        public int ReplyCount { get; set; }
        public bool IsLocked { get; set; }
        public bool IsSticky { get; set; }

        public StBrands Brand { get; set; }
        public StTickets Ticket { get; set; }
        public StUsers User { get; set; }
        public ICollection<StSearchTokensInThreads> StSearchTokensInThreads { get; set; }
        public ICollection<StThreadPosts> StThreadPosts { get; set; }
        public ICollection<StThreadTagsInThreads> StThreadTagsInThreads { get; set; }
        public ICollection<StThreadUserFlags> StThreadUserFlags { get; set; }
    }
}
