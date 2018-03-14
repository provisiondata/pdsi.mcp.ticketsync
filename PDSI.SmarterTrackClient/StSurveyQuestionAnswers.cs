using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StSurveyQuestionAnswers
    {
        public int SurveyQuestionAnswerId { get; set; }
        public int SurveyOfferedId { get; set; }
        public int? SurveyQuestionId { get; set; }
        public string TextAnswerValue { get; set; }
        public double? NumericAnswerValue { get; set; }
        public string QuestionAsAsked { get; set; }
        public double MaxQuestionValueAsAsked { get; set; }
        public double WeightAsAsked { get; set; }

        public StSurveysOffered SurveyOffered { get; set; }
        public StSurveyQuestions SurveyQuestion { get; set; }
    }
}
