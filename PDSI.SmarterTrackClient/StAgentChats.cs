using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StAgentChats
    {
        public StAgentChats()
        {
            StAgentChatMessages = new HashSet<StAgentChatMessages>();
            StAgentChatParticipants = new HashSet<StAgentChatParticipants>();
            StAgentChatPermissions = new HashSet<StAgentChatPermissions>();
        }

        public int AgentChatId { get; set; }
        public string ChatName { get; set; }
        public bool IsImchannel { get; set; }

        public ICollection<StAgentChatMessages> StAgentChatMessages { get; set; }
        public ICollection<StAgentChatParticipants> StAgentChatParticipants { get; set; }
        public ICollection<StAgentChatPermissions> StAgentChatPermissions { get; set; }
    }
}
