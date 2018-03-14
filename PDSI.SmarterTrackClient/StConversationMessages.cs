using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StConversationMessages
    {
        public long ConversationMessageId { get; set; }
        public long ConversationId { get; set; }
        public int UserIdFrom { get; set; }
        public int UserIdTo { get; set; }
        public DateTime DateSentUtc { get; set; }
        public string BodyHtml { get; set; }

        public StConversations Conversation { get; set; }
        public StUsers UserIdFromNavigation { get; set; }
        public StUsers UserIdToNavigation { get; set; }
    }
}
