using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StCustomDataFields
    {
        public StCustomDataFields()
        {
            StCustomDataFieldsForBrands = new HashSet<StCustomDataFieldsForBrands>();
            StCustomDataFieldsForDepartments = new HashSet<StCustomDataFieldsForDepartments>();
            StCustomDataFieldsForGroups = new HashSet<StCustomDataFieldsForGroups>();
            StCustomDataFieldsForUsers = new HashSet<StCustomDataFieldsForUsers>();
            StCustomDataFieldsInCallLogs = new HashSet<StCustomDataFieldsInCallLogs>();
            StCustomDataFieldsInChats = new HashSet<StCustomDataFieldsInChats>();
            StCustomDataFieldsInCustomTemplatesConditionalCustomField = new HashSet<StCustomDataFieldsInCustomTemplates>();
            StCustomDataFieldsInCustomTemplatesCustomField = new HashSet<StCustomDataFieldsInCustomTemplates>();
            StCustomDataFieldsInTickets = new HashSet<StCustomDataFieldsInTickets>();
        }

        public int CustomFieldId { get; set; }
        public string DisplayName { get; set; }
        public int DataType { get; set; }
        public string DefaultValue { get; set; }
        public string SpecialMapping { get; set; }
        public string Options { get; set; }
        public bool IsGlobal { get; set; }

        public ICollection<StCustomDataFieldsForBrands> StCustomDataFieldsForBrands { get; set; }
        public ICollection<StCustomDataFieldsForDepartments> StCustomDataFieldsForDepartments { get; set; }
        public ICollection<StCustomDataFieldsForGroups> StCustomDataFieldsForGroups { get; set; }
        public ICollection<StCustomDataFieldsForUsers> StCustomDataFieldsForUsers { get; set; }
        public ICollection<StCustomDataFieldsInCallLogs> StCustomDataFieldsInCallLogs { get; set; }
        public ICollection<StCustomDataFieldsInChats> StCustomDataFieldsInChats { get; set; }
        public ICollection<StCustomDataFieldsInCustomTemplates> StCustomDataFieldsInCustomTemplatesConditionalCustomField { get; set; }
        public ICollection<StCustomDataFieldsInCustomTemplates> StCustomDataFieldsInCustomTemplatesCustomField { get; set; }
        public ICollection<StCustomDataFieldsInTickets> StCustomDataFieldsInTickets { get; set; }
    }
}
