using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StKbArticles
    {
        public StKbArticles()
        {
            StKbAgentComments = new HashSet<StKbAgentComments>();
            StKbArticleComments = new HashSet<StKbArticleComments>();
            StKbArticleTranslationsKbArticleIdPrimaryNavigation = new HashSet<StKbArticleTranslations>();
            StKbArticleTranslationsKbArticleIdSecondaryNavigation = new HashSet<StKbArticleTranslations>();
            StKbArticlesBrands = new HashSet<StKbArticlesBrands>();
            StKbBrokenLinks = new HashSet<StKbBrokenLinks>();
            StKbDailyStats = new HashSet<StKbDailyStats>();
            StKbEventLogs = new HashSet<StKbEventLogs>();
            StKbScores = new HashSet<StKbScores>();
            StKbSearchLogs = new HashSet<StKbSearchLogs>();
            StKbViewLogs = new HashSet<StKbViewLogs>();
            StSearchTokensInKbarticles = new HashSet<StSearchTokensInKbarticles>();
        }

        public int KbArticleId { get; set; }
        public int? KbCategoryId { get; set; }
        public string Subject { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public DateTime DateModifiedUtc { get; set; }
        public DateTime DateLastReviewedUtc { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsDraft { get; set; }
        public bool IsIndexed { get; set; }
        public bool IsFlaggedForReview { get; set; }
        public bool IsDeleted { get; set; }
        public string Body { get; set; }
        public bool? DisplayInAllBrands { get; set; }
        public int? LanguageId { get; set; }
        public int TotalComments { get; set; }
        public string DetectedLanguage { get; set; }
        public bool HasBrokenLinks { get; set; }
        public int? UserId { get; set; }
        public int? KbArticleIdForwardTo { get; set; }
        public bool IsFeaturedInPortal { get; set; }
        public int Score { get; set; }
        public int ScoreVotes { get; set; }
        public string Summary { get; set; }

        public StKbCategories KbCategory { get; set; }
        public StLanguages Language { get; set; }
        public StUsers User { get; set; }
        public ICollection<StKbAgentComments> StKbAgentComments { get; set; }
        public ICollection<StKbArticleComments> StKbArticleComments { get; set; }
        public ICollection<StKbArticleTranslations> StKbArticleTranslationsKbArticleIdPrimaryNavigation { get; set; }
        public ICollection<StKbArticleTranslations> StKbArticleTranslationsKbArticleIdSecondaryNavigation { get; set; }
        public ICollection<StKbArticlesBrands> StKbArticlesBrands { get; set; }
        public ICollection<StKbBrokenLinks> StKbBrokenLinks { get; set; }
        public ICollection<StKbDailyStats> StKbDailyStats { get; set; }
        public ICollection<StKbEventLogs> StKbEventLogs { get; set; }
        public ICollection<StKbScores> StKbScores { get; set; }
        public ICollection<StKbSearchLogs> StKbSearchLogs { get; set; }
        public ICollection<StKbViewLogs> StKbViewLogs { get; set; }
        public ICollection<StSearchTokensInKbarticles> StSearchTokensInKbarticles { get; set; }
    }
}
