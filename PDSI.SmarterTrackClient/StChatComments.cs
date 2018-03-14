using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StChatComments
    {
        public int ChatCommentId { get; set; }
        public int CommentTypeId { get; set; }
        public int ChatId { get; set; }
        public int UserId { get; set; }
        public DateTime DateEnteredUtc { get; set; }
        public string CommentText { get; set; }
        public bool IsIndexed { get; set; }

        public StChats Chat { get; set; }
        public StCommentTypes CommentType { get; set; }
        public StUsers User { get; set; }
    }
}
