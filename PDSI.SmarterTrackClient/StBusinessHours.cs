using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StBusinessHours
    {
        public int BusinessHourId { get; set; }
        public int DayOfWeek { get; set; }
        public DateTime TimeStartUtc { get; set; }
        public DateTime TimeStopUtc { get; set; }
        public int? BrandId { get; set; }
        public int? DepartmentId { get; set; }

        public StBrands Brand { get; set; }
        public StDepartments Department { get; set; }
    }
}
