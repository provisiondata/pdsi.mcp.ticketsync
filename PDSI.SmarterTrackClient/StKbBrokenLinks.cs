using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StKbBrokenLinks
    {
        public int KbBrokenLinkId { get; set; }
        public int KbArticleId { get; set; }
        public string Link { get; set; }
        public string LinkText { get; set; }

        public StKbArticles KbArticle { get; set; }
    }
}
