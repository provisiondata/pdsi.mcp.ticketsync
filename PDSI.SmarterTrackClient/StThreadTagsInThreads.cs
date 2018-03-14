using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StThreadTagsInThreads
    {
        public int ThreadTagId { get; set; }
        public int ThreadId { get; set; }

        public StThreads Thread { get; set; }
        public StThreadTags ThreadTag { get; set; }
    }
}
