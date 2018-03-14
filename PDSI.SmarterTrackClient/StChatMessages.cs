using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StChatMessages
    {
        public long ChatMessageId { get; set; }
        public int ChatId { get; set; }
        public int? UserId { get; set; }
        public DateTime DateSubmittedUtc { get; set; }
        public int ChatSenderType { get; set; }
        public string TextSubmitted { get; set; }
        public int ViewRestriction { get; set; }
        public bool IsHtml { get; set; }

        public StChats Chat { get; set; }
        public StUsers User { get; set; }
    }
}
