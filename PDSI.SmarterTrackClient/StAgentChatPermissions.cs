using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StAgentChatPermissions
    {
        public int AgentChatPermissionId { get; set; }
        public int AgentChatId { get; set; }
        public int? UserId { get; set; }
        public int? GroupId { get; set; }
        public int? DepartmentId { get; set; }
        public int? BrandId { get; set; }
        public short? RoleId { get; set; }
        public bool IsAllowed { get; set; }

        public StAgentChats AgentChat { get; set; }
        public StBrands Brand { get; set; }
        public StRoles Role { get; set; }
        public StGroups StGroups { get; set; }
    }
}
