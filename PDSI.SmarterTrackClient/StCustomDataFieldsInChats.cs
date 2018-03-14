using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StCustomDataFieldsInChats
    {
        public int ChatId { get; set; }
        public int CustomFieldId { get; set; }
        public string DataContent { get; set; }

        public StChats Chat { get; set; }
        public StCustomDataFields CustomField { get; set; }
    }
}
