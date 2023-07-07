using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVC.DTO_s.Responses.Question
{
    public class QuestionDisplayResponse
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public int SurveyId { get; set; }
    }
}
