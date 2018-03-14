using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StEmailReports
    {
        public int EmailReportId { get; set; }
        public int CustomReportId { get; set; }
        public bool IsEnabled { get; set; }
        public int FrequencyType { get; set; }
        public DateTime DateNextSendUtc { get; set; }
        public string EmailTo { get; set; }
        public string EmailCc { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public bool IsHtml { get; set; }
        public bool ShowCharts { get; set; }
        public int UserId { get; set; }
        public int Culture { get; set; }

        public StCustomReports CustomReport { get; set; }
    }
}
