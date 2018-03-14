using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTranslatedStrings
    {
        public int TranslatedStringId { get; set; }
        public int TranslatableStringId { get; set; }
        public int LanguageId { get; set; }
        public string TranslatedValue { get; set; }

        public StLanguages Language { get; set; }
        public StTranslatableStrings TranslatableString { get; set; }
    }
}
