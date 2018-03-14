using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StUsersInRebalanceRules
    {
        public int RebalanceRuleId { get; set; }
        public int UserId { get; set; }

        public StRebalanceRules RebalanceRule { get; set; }
        public StUsers User { get; set; }
    }
}
