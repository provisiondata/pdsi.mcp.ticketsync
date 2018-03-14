using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StCustomDataFieldsInCustomTemplates
    {
        public int CustomTemplateId { get; set; }
        public int CustomFieldId { get; set; }
        public string DisplayName { get; set; }
        public bool IsVisible { get; set; }
        public bool IsRequired { get; set; }
        public int SortOrder { get; set; }
        public bool IsVisibleToAgents { get; set; }
        public bool IsRequiredToAgentRespondTicket { get; set; }
        public bool IsRequiredToAgentCloseTicket { get; set; }
        public bool IsVisibleInWidget { get; set; }
        public int? ConditionalCustomFieldId { get; set; }
        public string ConditionalValues { get; set; }

        public StCustomDataFields ConditionalCustomField { get; set; }
        public StCustomDataFields CustomField { get; set; }
        public StCustomTemplates CustomTemplate { get; set; }
    }
}
