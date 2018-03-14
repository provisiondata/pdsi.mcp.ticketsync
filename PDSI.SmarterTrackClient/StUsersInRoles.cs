using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StUsersInRoles
    {
        public int UserId { get; set; }
        public short RoleId { get; set; }
        public DateTime DateAddedUtc { get; set; }

        public StRoles Role { get; set; }
        public StUsers User { get; set; }
    }
}
