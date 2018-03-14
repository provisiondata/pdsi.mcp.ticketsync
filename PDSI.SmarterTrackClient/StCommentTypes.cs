using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StCommentTypes
    {
        public StCommentTypes()
        {
            StChatComments = new HashSet<StChatComments>();
            StTaskComments = new HashSet<StTaskComments>();
            StTicketComments = new HashSet<StTicketComments>();
            StUserComments = new HashSet<StUserComments>();
        }

        public int CommentTypeId { get; set; }
        public string EnglishName { get; set; }
        public string DisplayName { get; set; }
        public bool IncludeInSearchIndex { get; set; }
        public bool ShowInlineWithEmails { get; set; }

        public ICollection<StChatComments> StChatComments { get; set; }
        public ICollection<StTaskComments> StTaskComments { get; set; }
        public ICollection<StTicketComments> StTicketComments { get; set; }
        public ICollection<StUserComments> StUserComments { get; set; }
    }
}
