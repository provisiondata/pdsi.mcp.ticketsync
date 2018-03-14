using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StRoleAreaPermissions
    {
        public StRoleAreaPermissions()
        {
            StRolePermissions = new HashSet<StRolePermissions>();
        }

        public int RoleAreaPermissionsId { get; set; }
        public short RoleId { get; set; }
        public int RolePermissionsArea { get; set; }
        public int PagePermissionType { get; set; }

        public StRoles Role { get; set; }
        public ICollection<StRolePermissions> StRolePermissions { get; set; }
    }
}
