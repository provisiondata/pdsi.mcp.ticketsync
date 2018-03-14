using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTicketAttachments
    {
        public long TicketMessageId { get; set; }
        public int TicketId { get; set; }
        public int TicketAttachmentId { get; set; }
        public string FileNameOriginal { get; set; }
        public string FileNameOnDisk { get; set; }
        public string CidTagName { get; set; }
        public int Length { get; set; }
        public long Crc { get; set; }
        public DateTime CreationDateUtc { get; set; }
        public bool IsDeleted { get; set; }
        public int? UserId { get; set; }

        public StTickets Ticket { get; set; }
        public StUsers User { get; set; }
    }
}
