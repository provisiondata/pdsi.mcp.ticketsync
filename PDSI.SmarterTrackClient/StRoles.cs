using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StRoles
    {
        public StRoles()
        {
            StAgentChatPermissions = new HashSet<StAgentChatPermissions>();
            StDepartments = new HashSet<StDepartments>();
            StRoleAreaPermissions = new HashSet<StRoleAreaPermissions>();
            StRolePermissions = new HashSet<StRolePermissions>();
            StThreadTags = new HashSet<StThreadTags>();
            StUsersInRoles = new HashSet<StUsersInRoles>();
            StWebCustomActions = new HashSet<StWebCustomActions>();
        }

        public short RoleId { get; set; }
        public string RoleName { get; set; }
        public string LoweredRoleName { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsCustomRole { get; set; }
        public bool? ApplyParentKbCategoryPermissions { get; set; }
        public int RoleCategory { get; set; }

        public ICollection<StAgentChatPermissions> StAgentChatPermissions { get; set; }
        public ICollection<StDepartments> StDepartments { get; set; }
        public ICollection<StRoleAreaPermissions> StRoleAreaPermissions { get; set; }
        public ICollection<StRolePermissions> StRolePermissions { get; set; }
        public ICollection<StThreadTags> StThreadTags { get; set; }
        public ICollection<StUsersInRoles> StUsersInRoles { get; set; }
        public ICollection<StWebCustomActions> StWebCustomActions { get; set; }
    }
}
