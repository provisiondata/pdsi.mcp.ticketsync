using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StNewsItemsBrands
    {
        public int NewsItemId { get; set; }
        public int BrandId { get; set; }

        public StBrands Brand { get; set; }
        public StNewsItems NewsItem { get; set; }
    }
}
