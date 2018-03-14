using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StRolePageActionPermissionTypes
    {
        public StRolePageActionPermissionTypes()
        {
            StRolePermissions = new HashSet<StRolePermissions>();
        }

        public int RolePageActionPermissionTypeId { get; set; }
        public string EnglishName { get; set; }
        public string DisplayName { get; set; }
        public int RolePermissionsArea { get; set; }

        public ICollection<StRolePermissions> StRolePermissions { get; set; }
    }
}
