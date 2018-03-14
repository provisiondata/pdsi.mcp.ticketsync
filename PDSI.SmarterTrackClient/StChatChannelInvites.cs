using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StChatChannelInvites
    {
        public int ChatChannelInviteId { get; set; }
        public int ChatChannelId { get; set; }
        public int UserIdFrom { get; set; }
        public int UserIdTo { get; set; }
        public string RelatedChatNumber { get; set; }
        public string RelatedTicketNumber { get; set; }
        public int InviteStatus { get; set; }
        public int InviteType { get; set; }
        public DateTime DateIssuedUtc { get; set; }
        public DateTime? DateRespondedUtc { get; set; }
        public string InvitationMessage { get; set; }
        public bool IsAutoPopup { get; set; }

        public StChatChannels ChatChannel { get; set; }
        public StUsers UserIdFromNavigation { get; set; }
        public StUsers UserIdToNavigation { get; set; }
    }
}
