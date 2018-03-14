using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StSurveyQuestionPredefinedAnswers
    {
        public int AnswerId { get; set; }
        public int SurveyQuestionId { get; set; }
        public string AnswerText { get; set; }
        public double AnswerValue { get; set; }

        public StSurveyQuestions SurveyQuestion { get; set; }
    }
}
