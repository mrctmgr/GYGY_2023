using SurveyAppMVC.Entities;
using SurveyAppMVC.Infrastructure.Repository;
using SurveyAppMVCMVC.DTO_s.Requests.Participant;
using SurveyAppMVCMVC.DTO_s.Responses.Participant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVC.Services
{
    public class ParticipantService : IParticipantService
    {
        private readonly IParticipantRepository repository;
        public ParticipantService(IParticipantRepository repository)
        {
            this.repository = repository;
        }

        public async Task CreateParticipantAsync(CreateNewParticipantRequest request)
        {
            var participant = new Participant
            {
                ParticipantName = request.Name,
                ParticipantSurname = request.Surname,
                ParticipantPassword = request.Password,
                ParticipantEmail = request.Email,
                Role = request.Role
            };
            await repository.CreateAsync(participant);
        }

        public async Task DeleteParticipantAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ParticipantDisplayResponse>> GetAllParticipantsAsync()
        {
            var participants = await repository.GetAllAsync();
            var responses = participants.Select(participant => new ParticipantDisplayResponse
            {
                Id = participant.Id,
                Name = participant.ParticipantName,
                Surname = participant.ParticipantSurname,
                Email = participant.ParticipantEmail,
                Password = participant.ParticipantPassword,
                Role = participant.Role 
            });
            return responses;
        }

        public async Task<ParticipantDisplayResponse> GetParticipantAsync(int id)
        {
            var participant = await repository.GetAsync(id);
            var response = new ParticipantDisplayResponse
            {
                Id = participant.Id,
                Name =  participant.ParticipantName,
                Surname = participant.ParticipantSurname,
                Email = participant.ParticipantEmail,
                Password = participant.ParticipantPassword,
                Role = participant.Role
            };
            return response;
        }

        public Task UpdateParticipantAsync(UpdateExistingParticipantRequest request)
        {
            var updatedParticipant = new Participant
            {
                Id = request.Id,
                ParticipantName = request.Name,
                ParticipantSurname = request.Surname,
                ParticipantEmail = request.Email,
                ParticipantPassword = request.Password,
                Role = request.Role
            };
            return repository.UpdateAsync(updatedParticipant);
        }

    }
}
