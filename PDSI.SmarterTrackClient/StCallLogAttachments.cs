using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StCallLogAttachments
    {
        public int CallLogAttachmentId { get; set; }
        public int CallLogId { get; set; }
        public int? UserId { get; set; }
        public string FileNameOriginal { get; set; }
        public string FileNameOnDisk { get; set; }
        public int Length { get; set; }
        public long Crc { get; set; }
        public DateTime CreationDateUtc { get; set; }
        public bool IsDeleted { get; set; }

        public StCallLogs CallLog { get; set; }
        public StUsers User { get; set; }
    }
}
