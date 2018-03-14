using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTaskComments
    {
        public int TaskCommentId { get; set; }
        public int TaskId { get; set; }
        public int CommentTypeId { get; set; }
        public int UserId { get; set; }
        public DateTime DateEnteredUtc { get; set; }
        public string CommentText { get; set; }
        public bool IsIndexed { get; set; }

        public StCommentTypes CommentType { get; set; }
        public StTasks Task { get; set; }
        public StUsers User { get; set; }
    }
}
