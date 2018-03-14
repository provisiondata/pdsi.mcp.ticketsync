using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StEventGroups
    {
        public int EventGroupId { get; set; }
        public int? UserId { get; set; }
        public string EventGroupName { get; set; }

        public StUsers User { get; set; }
    }
}
