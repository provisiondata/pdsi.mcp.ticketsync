using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StEmailTemplates
    {
        public int EmailTemplateId { get; set; }
        public string DisplayName { get; set; }
        public bool IsHtml { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
