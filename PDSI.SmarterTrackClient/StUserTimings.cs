using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StUserTimings
    {
        public DateTime TimingStartUtc { get; set; }
        public int DepartmentId { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public DateTime? TimingEndUtc { get; set; }
        public int? ElapsedSeconds { get; set; }
        public bool ActiveForTickets { get; set; }
        public bool ActiveForChats { get; set; }
        public bool IsAfk { get; set; }

        public StGroups StGroups { get; set; }
        public StUsers User { get; set; }
    }
}
