using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StRecurringTaskDays
    {
        public int RecurringDaskDaysId { get; set; }
        public int RecurringTaskId { get; set; }
        public int DayOfWeek { get; set; }

        public StRecurringTasks RecurringTask { get; set; }
    }
}
