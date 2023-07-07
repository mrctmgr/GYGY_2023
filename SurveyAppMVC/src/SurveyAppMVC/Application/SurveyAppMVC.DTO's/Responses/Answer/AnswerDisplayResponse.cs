using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVC.DTO_s.Responses.Answer
{
    public class AnswerDisplayResponse
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public int SurveyId { get; set; }
    }
}
