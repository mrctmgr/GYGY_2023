using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVCMVC.DTO_s.Requests.Participant
{
    public class CreateNewParticipantRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
    }
}
