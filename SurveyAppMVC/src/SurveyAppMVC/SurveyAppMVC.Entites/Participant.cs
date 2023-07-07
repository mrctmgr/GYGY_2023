using SurveyAppMVCMVC.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVC.Entities
{
    public class Participant : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string ParticipantName { get; set; }
        [Required]
        public string ParticipantSurname { get; set; }
        [Required]
        public string ParticipantEmail { get; set; }
        [Required]
        public string Role { get; set; }
        public string ParticipantPassword { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}
