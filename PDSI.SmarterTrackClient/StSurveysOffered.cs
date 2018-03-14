using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StSurveysOffered
    {
        public StSurveysOffered()
        {
            StSurveyQuestionAnswers = new HashSet<StSurveyQuestionAnswers>();
        }

        public int SurveyOfferedId { get; set; }
        public int SurveyDefinitionId { get; set; }
        public int SurveyOfferedUserContextId { get; set; }
        public Guid SurveyGuid { get; set; }
        public DateTime OfferedAt { get; set; }
        public DateTime? ViewedAt { get; set; }
        public DateTime? AnsweredAt { get; set; }
        public double? Rating { get; set; }

        public StSurveyDefinitions SurveyDefinition { get; set; }
        public StSurveyOfferedUserContext SurveyOfferedUserContext { get; set; }
        public ICollection<StSurveyQuestionAnswers> StSurveyQuestionAnswers { get; set; }
    }
}
