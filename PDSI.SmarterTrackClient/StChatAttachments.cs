using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StChatAttachments
    {
        public int ChatAttachmentId { get; set; }
        public int ChatId { get; set; }
        public int? UserId { get; set; }
        public string FileNameOriginal { get; set; }
        public string FileNameOnDisk { get; set; }
        public int Length { get; set; }
        public long Crc { get; set; }
        public DateTime CreationDateUtc { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsOutgoing { get; set; }

        public StChats Chat { get; set; }
        public StUsers User { get; set; }
    }
}
