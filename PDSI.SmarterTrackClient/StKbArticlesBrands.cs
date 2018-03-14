using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StKbArticlesBrands
    {
        public int KbArticleId { get; set; }
        public int BrandId { get; set; }

        public StBrands Brand { get; set; }
        public StKbArticles KbArticle { get; set; }
    }
}
