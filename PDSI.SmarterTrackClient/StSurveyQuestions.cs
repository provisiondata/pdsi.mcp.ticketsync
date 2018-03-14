using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StSurveyQuestions
    {
        public StSurveyQuestions()
        {
            StSurveyQuestionAnswers = new HashSet<StSurveyQuestionAnswers>();
            StSurveyQuestionPredefinedAnswers = new HashSet<StSurveyQuestionPredefinedAnswers>();
        }

        public int SurveyQuestionId { get; set; }
        public int SurveyDefinitionId { get; set; }
        public int QuestionType { get; set; }
        public string Question { get; set; }
        public double Weight { get; set; }
        public DateTime QuestionAdded { get; set; }
        public DateTime? QuestionEdited { get; set; }
        public bool IsRequired { get; set; }
        public int? RenderOption { get; set; }
        public int QuestionNumber { get; set; }

        public StSurveyDefinitions SurveyDefinition { get; set; }
        public ICollection<StSurveyQuestionAnswers> StSurveyQuestionAnswers { get; set; }
        public ICollection<StSurveyQuestionPredefinedAnswers> StSurveyQuestionPredefinedAnswers { get; set; }
    }
}
