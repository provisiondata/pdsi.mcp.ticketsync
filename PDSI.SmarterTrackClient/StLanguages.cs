using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StLanguages
    {
        public StLanguages()
        {
            StCannedReplies = new HashSet<StCannedReplies>();
            StDepartments = new HashSet<StDepartments>();
            StKbArticles = new HashSet<StKbArticles>();
            StNewsItems = new HashSet<StNewsItems>();
            StTranslatedStrings = new HashSet<StTranslatedStrings>();
        }

        public int LanguageId { get; set; }
        public int Lcid { get; set; }
        public string CultureName { get; set; }
        public string LanguageName { get; set; }
        public bool IsDefault { get; set; }
        public bool IsVisible { get; set; }

        public ICollection<StCannedReplies> StCannedReplies { get; set; }
        public ICollection<StDepartments> StDepartments { get; set; }
        public ICollection<StKbArticles> StKbArticles { get; set; }
        public ICollection<StNewsItems> StNewsItems { get; set; }
        public ICollection<StTranslatedStrings> StTranslatedStrings { get; set; }
    }
}
