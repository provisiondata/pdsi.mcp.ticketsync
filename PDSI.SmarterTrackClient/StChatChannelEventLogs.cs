﻿using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StChatChannelEventLogs
    {
        public DateTime EventDateUtc { get; set; }
        public short Uniquifier { get; set; }
        public int EventTypeId { get; set; }
        public int ChatChannelId { get; set; }
        public int? UserId { get; set; }
        public int? UserIdtakingAction { get; set; }
        public int InterfaceUsed { get; set; }

        public StChatChannels ChatChannel { get; set; }
        public StUsers User { get; set; }
        public StUsers UserIdtakingActionNavigation { get; set; }
    }
}
