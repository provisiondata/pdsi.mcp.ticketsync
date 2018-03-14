using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StBusinessHolidays
    {
        public int BusinessHolidayId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int? BrandId { get; set; }
        public int? DepartmentId { get; set; }

        public StBrands Brand { get; set; }
        public StDepartments Department { get; set; }
    }
}
