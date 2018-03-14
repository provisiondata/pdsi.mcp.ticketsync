using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StNewsItemBrokenLinks
    {
        public int NewsItemBrokenLinkId { get; set; }
        public int NewsItemId { get; set; }
        public string Link { get; set; }
        public string LinkText { get; set; }

        public StNewsItems NewsItem { get; set; }
    }
}
