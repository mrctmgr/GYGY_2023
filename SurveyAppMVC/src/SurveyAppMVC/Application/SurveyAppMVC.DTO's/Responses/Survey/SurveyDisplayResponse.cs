using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVC.DTO_s.Responses.Survey
{
    public class SurveyDisplayResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public int ParticipateId { get; set; }
    }
}
