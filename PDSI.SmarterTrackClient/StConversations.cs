using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StConversations
    {
        public StConversations()
        {
            StConversationMessages = new HashSet<StConversationMessages>();
        }

        public long ConversationId { get; set; }
        public int UserId1 { get; set; }
        public int UserId2 { get; set; }
        public bool User1Closed { get; set; }
        public bool User2Closed { get; set; }
        public bool User1HasUnread { get; set; }
        public bool User2HasUnread { get; set; }
        public DateTime DateLastSentUtc { get; set; }
        public bool User1Deleted { get; set; }
        public bool User2Deleted { get; set; }

        public StUsers UserId1Navigation { get; set; }
        public StUsers UserId2Navigation { get; set; }
        public ICollection<StConversationMessages> StConversationMessages { get; set; }
    }
}
