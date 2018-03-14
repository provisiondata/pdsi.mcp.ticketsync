using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StCustomTemplates
    {
        public StCustomTemplates()
        {
            StCustomDataFieldsInCustomTemplates = new HashSet<StCustomDataFieldsInCustomTemplates>();
            StDepartmentsCustomTemplateIdCallLogNavigation = new HashSet<StDepartments>();
            StDepartmentsCustomTemplateIdChatNavigation = new HashSet<StDepartments>();
            StDepartmentsCustomTemplateIdTicketNavigation = new HashSet<StDepartments>();
        }

        public int CustomTemplateId { get; set; }
        public string DisplayName { get; set; }

        public ICollection<StCustomDataFieldsInCustomTemplates> StCustomDataFieldsInCustomTemplates { get; set; }
        public ICollection<StDepartments> StDepartmentsCustomTemplateIdCallLogNavigation { get; set; }
        public ICollection<StDepartments> StDepartmentsCustomTemplateIdChatNavigation { get; set; }
        public ICollection<StDepartments> StDepartmentsCustomTemplateIdTicketNavigation { get; set; }
    }
}
