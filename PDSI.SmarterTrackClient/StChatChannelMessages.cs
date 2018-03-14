using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StChatChannelMessages
    {
        public int ChatChannelMessageId { get; set; }
        public int ChatChannelId { get; set; }
        public int? UserId { get; set; }
        public int ChatSenderType { get; set; }
        public DateTime DateSubmittedUtc { get; set; }
        public string TextSubmitted { get; set; }
        public bool IsHtml { get; set; }
        public int ViewRestriction { get; set; }

        public StChatChannels ChatChannel { get; set; }
        public StUsers User { get; set; }
    }
}
