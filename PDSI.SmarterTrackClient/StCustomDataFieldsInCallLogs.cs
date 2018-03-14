using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StCustomDataFieldsInCallLogs
    {
        public int CallLogId { get; set; }
        public int CustomFieldId { get; set; }
        public string DataContent { get; set; }

        public StCallLogs CallLog { get; set; }
        public StCustomDataFields CustomField { get; set; }
    }
}
