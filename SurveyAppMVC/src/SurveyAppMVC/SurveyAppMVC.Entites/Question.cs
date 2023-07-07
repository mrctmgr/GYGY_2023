using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVCMVC.Entities
{
    public class Question : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string QuestionText { get; set; }
        public int SurveyId { get; set; }
        public string QuestionType { get; set; }
        public Survey Survey { get; set; }
        public ICollection<Answer> Answers { get; set; }

    }
}
