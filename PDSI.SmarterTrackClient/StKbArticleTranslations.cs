using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StKbArticleTranslations
    {
        public int KbArticleTranslationId { get; set; }
        public int KbArticleIdPrimary { get; set; }
        public int KbArticleIdSecondary { get; set; }

        public StKbArticles KbArticleIdPrimaryNavigation { get; set; }
        public StKbArticles KbArticleIdSecondaryNavigation { get; set; }
    }
}
