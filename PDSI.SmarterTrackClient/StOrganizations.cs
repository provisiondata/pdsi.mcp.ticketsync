using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StOrganizations
    {
        public StOrganizations()
        {
            StOrganizationFilters = new HashSet<StOrganizationFilters>();
        }

        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public string Website { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<StOrganizationFilters> StOrganizationFilters { get; set; }
    }
}
