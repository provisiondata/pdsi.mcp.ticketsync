using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StDepartmentSettings
    {
        public int DepartmentId { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }

        public StDepartments Department { get; set; }
    }
}
