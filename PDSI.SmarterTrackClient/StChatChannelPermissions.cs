using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StChatChannelPermissions
    {
        public int ChatChannelPermissionId { get; set; }
        public int ChatChannelId { get; set; }
        public int? UserId { get; set; }
        public int? GroupId { get; set; }
        public int? DepartmentId { get; set; }
        public int? RoleId { get; set; }
        public bool IsAllowed { get; set; }

        public StChatChannels ChatChannel { get; set; }
        public StGroups StGroups { get; set; }
        public StUsers User { get; set; }
    }
}
