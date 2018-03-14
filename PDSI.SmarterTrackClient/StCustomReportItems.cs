using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StCustomReportItems
    {
        public int CustomReportId { get; set; }
        public int CustomReportItemId { get; set; }
        public Guid ReportItemGuid { get; set; }
        public string DisplayName { get; set; }
        public int DisplayOrder { get; set; }
        public string DateRange { get; set; }
        public int? MaxRows { get; set; }
        public string SortBy { get; set; }
        public string ChartType { get; set; }
        public string ChartColumns { get; set; }
        public string GroupBy { get; set; }
        public string FilterBy { get; set; }

        public StCustomReports CustomReport { get; set; }
    }
}
