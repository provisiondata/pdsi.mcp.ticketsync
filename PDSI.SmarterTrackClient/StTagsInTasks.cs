using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTagsInTasks
    {
        public int TagsInTasksId { get; set; }
        public int TaskId { get; set; }
        public int TagId { get; set; }
        public DateTime DateAddedUtc { get; set; }

        public StTags Tag { get; set; }
        public StTasks Task { get; set; }
    }
}
