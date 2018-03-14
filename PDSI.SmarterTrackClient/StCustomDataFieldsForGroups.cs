using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StCustomDataFieldsForGroups
    {
        public int GroupId { get; set; }
        public int DepartmentId { get; set; }
        public int CustomFieldId { get; set; }
        public string DataContent { get; set; }

        public StCustomDataFields CustomField { get; set; }
        public StGroups StGroups { get; set; }
    }
}
