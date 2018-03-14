using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTicketComments
    {
        public int TicketId { get; set; }
        public int TicketCommentId { get; set; }
        public int CommentTypeId { get; set; }
        public int UserId { get; set; }
        public DateTime DateEnteredUtc { get; set; }
        public string CommentText { get; set; }
        public bool IsIndexed { get; set; }

        public StCommentTypes CommentType { get; set; }
        public StTickets Ticket { get; set; }
        public StUsers User { get; set; }
    }
}
