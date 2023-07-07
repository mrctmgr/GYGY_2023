using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVC.DTO_s.Requests.Survey
{
    public class CreateNewSurveyRequest
    {
        public string Name { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public int ParticipantId { get; set; }
    }
}
