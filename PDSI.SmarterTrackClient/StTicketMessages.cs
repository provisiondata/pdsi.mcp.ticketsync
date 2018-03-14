using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTicketMessages
    {
        public StTicketMessages()
        {
            StTicketEventLogs = new HashSet<StTicketEventLogs>();
        }

        public long TicketMessageId { get; set; }
        public int TicketId { get; set; }
        public DateTime DateReceivedUtc { get; set; }
        public int? UserIdFrom { get; set; }
        public string Subject { get; set; }
        public string BodyText { get; set; }
        public string BodyHtml { get; set; }
        public int? MessageDirection { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public string CcAddresses { get; set; }
        public int DeliveryStatus { get; set; }
        public string LastDeliveryError { get; set; }
        public int? FileIdrawContent { get; set; }
        public string SmtpMessageGuid { get; set; }
        public bool IsFirstMessageOfTicket { get; set; }
        public bool ShowAllMessageContent { get; set; }
        public bool IsDraft { get; set; }

        public StFiles FileIdrawContentNavigation { get; set; }
        public StTickets Ticket { get; set; }
        public StUsers UserIdFromNavigation { get; set; }
        public ICollection<StTicketEventLogs> StTicketEventLogs { get; set; }
    }
}
