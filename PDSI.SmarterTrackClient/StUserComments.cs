using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StUserComments
    {
        public int UserCommentId { get; set; }
        public int UserId { get; set; }
        public int UserIdFrom { get; set; }
        public string CommentText { get; set; }
        public DateTime DateEnteredUtc { get; set; }
        public int CommentTypeId { get; set; }

        public StCommentTypes CommentType { get; set; }
        public StUsers User { get; set; }
        public StUsers UserIdFromNavigation { get; set; }
    }
}
