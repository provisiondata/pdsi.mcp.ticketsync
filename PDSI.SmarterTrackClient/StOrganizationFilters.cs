using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StOrganizationFilters
    {
        public int OrganizationFilterId { get; set; }
        public int OrganizationId { get; set; }
        public string FilterType { get; set; }
        public string FilterValue { get; set; }
        public int? UserId { get; set; }

        public StOrganizations Organization { get; set; }
        public StUsers User { get; set; }
    }
}
