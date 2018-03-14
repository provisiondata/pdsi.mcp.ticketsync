using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StWhosOnAgentChatParticipation
    {
        public int WhosOnAgentChatParticipationId { get; set; }
        public int ChatChannelId { get; set; }
        public DateTime DateLastAsyncCheckUtc { get; set; }
        public DateTime DateLastMessageSentUtc { get; set; }
        public DateTime DateFirstJoinedUtc { get; set; }
        public int DurationSeconds { get; set; }
        public int IdleSeconds { get; set; }
        public bool IsAfk { get; set; }
        public int UserId { get; set; }

        public StChatChannels ChatChannel { get; set; }
    }
}
