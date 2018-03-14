using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StTranslatableStrings
    {
        public StTranslatableStrings()
        {
            StTranslatedStrings = new HashSet<StTranslatedStrings>();
        }

        public int TranslatableStringId { get; set; }
        public string TranslatableString { get; set; }
        public string TranslatableDescription { get; set; }

        public ICollection<StTranslatedStrings> StTranslatedStrings { get; set; }
    }
}
