using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StDepartmentsInChatImageConfigs
    {
        public int ChatImageConfigId { get; set; }
        public int DepartmentId { get; set; }

        public StChatImageConfigs ChatImageConfig { get; set; }
        public StDepartments Department { get; set; }
    }
}
