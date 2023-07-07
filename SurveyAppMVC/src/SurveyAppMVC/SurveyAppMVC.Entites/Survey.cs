using SurveyAppMVC.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVCMVC.Entities
{
    public class Survey : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string SurveyName { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public ICollection<Question> Questions { get; set; }
        public int QuestionsCount { get; set;}
        public Participant Participant { get; set; }
        public int ParticipantId { get; set; }
        public ICollection<Answer> Answers { get; set; }

    }
}
