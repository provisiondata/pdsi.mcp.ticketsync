using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StSurveyDefinitions
    {
        public StSurveyDefinitions()
        {
            StDepartmentsSurveyDefinitionIdafterChatNavigation = new HashSet<StDepartments>();
            StDepartmentsSurveyDefinitionIdafterTicketNavigation = new HashSet<StDepartments>();
            StSurveyQuestions = new HashSet<StSurveyQuestions>();
            StSurveysOffered = new HashSet<StSurveysOffered>();
        }

        public int SurveyDefinitionId { get; set; }
        public string HeaderText { get; set; }
        public string ThankYouText { get; set; }
        public string SurveyName { get; set; }
        public string LinkText { get; set; }

        public ICollection<StDepartments> StDepartmentsSurveyDefinitionIdafterChatNavigation { get; set; }
        public ICollection<StDepartments> StDepartmentsSurveyDefinitionIdafterTicketNavigation { get; set; }
        public ICollection<StSurveyQuestions> StSurveyQuestions { get; set; }
        public ICollection<StSurveysOffered> StSurveysOffered { get; set; }
    }
}
