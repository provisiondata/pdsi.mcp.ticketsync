using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StSurveyOfferedUserContext
    {
        public StSurveyOfferedUserContext()
        {
            StSurveysOffered = new HashSet<StSurveysOffered>();
        }

        public int SurveyOfferedUserContextId { get; set; }
        public string VisitorId { get; set; }
        public int? UserId { get; set; }
        public string EmailAddress { get; set; }
        public int? TicketId { get; set; }
        public int? ChatId { get; set; }

        public StChats Chat { get; set; }
        public StTickets Ticket { get; set; }
        public StUsers User { get; set; }
        public ICollection<StSurveysOffered> StSurveysOffered { get; set; }
    }
}
