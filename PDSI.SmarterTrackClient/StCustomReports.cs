using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StCustomReports
    {
        public StCustomReports()
        {
            StCustomReportItems = new HashSet<StCustomReportItems>();
            StEmailReports = new HashSet<StEmailReports>();
        }

        public int CustomReportId { get; set; }
        public int UserId { get; set; }
        public string DisplayName { get; set; }
        public string DateRange { get; set; }

        public StUsers User { get; set; }
        public ICollection<StCustomReportItems> StCustomReportItems { get; set; }
        public ICollection<StEmailReports> StEmailReports { get; set; }
    }
}
