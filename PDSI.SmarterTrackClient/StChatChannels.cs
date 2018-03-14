using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StChatChannels
    {
        public StChatChannels()
        {
            StChatChannelEventLogs = new HashSet<StChatChannelEventLogs>();
            StChatChannelInvites = new HashSet<StChatChannelInvites>();
            StChatChannelMessages = new HashSet<StChatChannelMessages>();
            StChatChannelPermissions = new HashSet<StChatChannelPermissions>();
            StWhosOnAgentChatParticipation = new HashSet<StWhosOnAgentChatParticipation>();
        }

        public int ChatChannelId { get; set; }
        public string ChatChannelName { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public DateTime DateModifiedUtc { get; set; }
        public DateTime? DateEndedUtc { get; set; }
        public DateTime? DateDeletedUtc { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsShortLivedChannel { get; set; }
        public DateTime? DateInactiveUtc { get; set; }
        public string StartedBy { get; set; }

        public ICollection<StChatChannelEventLogs> StChatChannelEventLogs { get; set; }
        public ICollection<StChatChannelInvites> StChatChannelInvites { get; set; }
        public ICollection<StChatChannelMessages> StChatChannelMessages { get; set; }
        public ICollection<StChatChannelPermissions> StChatChannelPermissions { get; set; }
        public ICollection<StWhosOnAgentChatParticipation> StWhosOnAgentChatParticipation { get; set; }
    }
}
