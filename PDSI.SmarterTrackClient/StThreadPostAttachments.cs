using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StThreadPostAttachments
    {
        public int ThreadPostAttachmentId { get; set; }
        public int ThreadId { get; set; }
        public int ThreadPostId { get; set; }
        public int UserId { get; set; }
        public string FileNameOriginal { get; set; }
        public string FileNameOnDisk { get; set; }
        public string CidTagName { get; set; }
        public int Length { get; set; }
        public long Crc { get; set; }
        public DateTime CreationDateUtc { get; set; }
        public bool IsDeleted { get; set; }

        public StThreadPosts ThreadPost { get; set; }
    }
}
