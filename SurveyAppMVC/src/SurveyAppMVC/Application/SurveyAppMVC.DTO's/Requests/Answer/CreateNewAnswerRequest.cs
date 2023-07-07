using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVCMVC.DTO_s.Requests.Answer
{
    public class CreateNewAnswerRequest
    {
        public string Answers { get; set; }
        public DateTime AnswerDate { get; set; }
        public int SurveyId { get; set; }
    }
}
