using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StRolePermissions
    {
        public int RolePermissionId { get; set; }
        public short RoleId { get; set; }
        public int RolePageActionPermissionTypeId { get; set; }
        public bool IsAllowed { get; set; }
        public int? KbCategoryId { get; set; }
        public string ReportItemGuid { get; set; }
        public int RoleAreaPermissionsId { get; set; }

        public StKbCategories KbCategory { get; set; }
        public StRoles Role { get; set; }
        public StRoleAreaPermissions RoleAreaPermissions { get; set; }
        public StRolePageActionPermissionTypes RolePageActionPermissionType { get; set; }
    }
}
