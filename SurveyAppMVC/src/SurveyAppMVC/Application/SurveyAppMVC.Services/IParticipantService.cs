using SurveyAppMVCMVC.DTO_s.Requests.Participant;
using SurveyAppMVCMVC.DTO_s.Responses.Participant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVC.Services
{
    public interface IParticipantService
    {
        Task<ParticipantDisplayResponse> GetParticipantAsync(int id);
        Task<IEnumerable<ParticipantDisplayResponse>> GetAllParticipantsAsync();
        Task CreateParticipantAsync(CreateNewParticipantRequest request);
        Task DeleteParticipantAsync(int id);
        Task UpdateParticipantAsync(UpdateExistingParticipantRequest request);
    }
}
