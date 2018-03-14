using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StRssFeeds
    {
        public int RssFeedId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public DateTime DateModifiedUtc { get; set; }
        public bool ShowDescription { get; set; }
        public int SortOrder { get; set; }
        public int? BrandId { get; set; }
        public bool? ShowImage { get; set; }

        public StBrands Brand { get; set; }
    }
}
