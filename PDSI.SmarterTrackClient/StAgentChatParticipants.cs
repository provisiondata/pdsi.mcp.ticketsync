using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StAgentChatParticipants
    {
        public int AgentChatParticipantId { get; set; }
        public int AgentChatId { get; set; }
        public int? UserId { get; set; }
        public bool IsMuted { get; set; }
        public int? LastReadMessageId { get; set; }
        public string DisplayName { get; set; }

        public StAgentChats AgentChat { get; set; }
        public StUsers User { get; set; }
    }
}
