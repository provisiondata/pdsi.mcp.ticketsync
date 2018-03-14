using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StNewsItems
    {
        public StNewsItems()
        {
            StNewsEventLogs = new HashSet<StNewsEventLogs>();
            StNewsItemBrokenLinks = new HashSet<StNewsItemBrokenLinks>();
            StNewsItemTranslationsNewsItemIdPrimaryNavigation = new HashSet<StNewsItemTranslations>();
            StNewsItemTranslationsNewsItemIdSecondaryNavigation = new HashSet<StNewsItemTranslations>();
            StNewsItemsBrands = new HashSet<StNewsItemsBrands>();
            StNewsViewLogs = new HashSet<StNewsViewLogs>();
        }

        public int NewsItemId { get; set; }
        public Guid NewsItemGuid { get; set; }
        public DateTime? EventDateUtc { get; set; }
        public string Subject { get; set; }
        public string SummaryShort { get; set; }
        public string SummaryLong { get; set; }
        public string Body { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsDraft { get; set; }
        public bool IsFlaggedForReview { get; set; }
        public bool IsDeleted { get; set; }
        public bool? DisplayInAllBrands { get; set; }
        public int? LanguageId { get; set; }
        public bool HasBrokenLinks { get; set; }

        public StLanguages Language { get; set; }
        public ICollection<StNewsEventLogs> StNewsEventLogs { get; set; }
        public ICollection<StNewsItemBrokenLinks> StNewsItemBrokenLinks { get; set; }
        public ICollection<StNewsItemTranslations> StNewsItemTranslationsNewsItemIdPrimaryNavigation { get; set; }
        public ICollection<StNewsItemTranslations> StNewsItemTranslationsNewsItemIdSecondaryNavigation { get; set; }
        public ICollection<StNewsItemsBrands> StNewsItemsBrands { get; set; }
        public ICollection<StNewsViewLogs> StNewsViewLogs { get; set; }
    }
}
