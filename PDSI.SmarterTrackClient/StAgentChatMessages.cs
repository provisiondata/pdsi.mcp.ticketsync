using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StAgentChatMessages
    {
        public int AgentChatMessageId { get; set; }
        public int AgentChatId { get; set; }
        public int? AgentChatParticipantId { get; set; }
        public DateTime DateSubmittedUtc { get; set; }
        public string TextSubmitted { get; set; }
        public bool IsHtml { get; set; }

        public StAgentChats AgentChat { get; set; }
    }
}
