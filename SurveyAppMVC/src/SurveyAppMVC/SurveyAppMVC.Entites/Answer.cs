using SurveyAppMVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVCMVC.Entities
{
    public class Answer : IEntity
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int ParticipantId { get; set; }
        public string AnswerText { get; set; }
        public int SurveyId { get; set; }
        public Question Question { get; set; }
        public Participant Participant { get; set; }
        public Survey Survey { get; set; }

    }
}
