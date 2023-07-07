using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVCMVC.DTO_s.Requests.Survey
{
    public class UpdateExistingSurveyRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public int ParticipantId { get; set; }
    }
}
