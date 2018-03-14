using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StCustomDataFieldsForUsers
    {
        public int UserId { get; set; }
        public int CustomFieldId { get; set; }
        public string DataContent { get; set; }

        public StCustomDataFields CustomField { get; set; }
        public StUsers User { get; set; }
    }
}
