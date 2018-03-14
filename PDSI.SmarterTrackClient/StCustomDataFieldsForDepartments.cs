using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StCustomDataFieldsForDepartments
    {
        public int DepartmentId { get; set; }
        public int CustomFieldId { get; set; }
        public string DataContent { get; set; }

        public StCustomDataFields CustomField { get; set; }
        public StDepartments Department { get; set; }
    }
}
