using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StNewsItemTranslations
    {
        public int NewsItemTranslationId { get; set; }
        public int NewsItemIdPrimary { get; set; }
        public int NewsItemIdSecondary { get; set; }

        public StNewsItems NewsItemIdPrimaryNavigation { get; set; }
        public StNewsItems NewsItemIdSecondaryNavigation { get; set; }
    }
}
