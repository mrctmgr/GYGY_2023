using SurveyAppMVC.DTO_s.Requests.Survey;
using SurveyAppMVC.DTO_s.Responses.Survey;
using SurveyAppMVC.Entities;
using SurveyAppMVC.Infrastructure.Repository;
using SurveyAppMVCMVC.DTO_s.Requests.Survey;
using SurveyAppMVCMVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVC.Services
{
    public class SurveyService : ISurveyService
    {
        private readonly ISurveyRepository repository;
        public SurveyService(ISurveyRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Survey> CreateSurveyAsync(CreateNewSurveyRequest request)
        {
            var survey = new Survey
            {
                SurveyName = request.Name,
                Created = request.Created,
                Id = request.ParticipantId,
            };
            await repository.CreateAsync(survey);
            return survey;
        }

        public async Task DeleteSurveyAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<SurveyDisplayResponse>> GetAllSurveysAsync()
        {
            var surveys = await repository.GetAllAsync();
            var responses = surveys.Select(survey => new SurveyDisplayResponse
            {
                Id = survey.Id,
                Name = survey.SurveyName,
                Created = survey.Created,
                ParticipateId = survey.Id
            });
            return responses;
        }

        public async Task<SurveyDisplayResponse> GetSurveyAsync(int id)
        {
            var survey = await repository.GetAsync(id);
            var response = new SurveyDisplayResponse
            {
                Id = survey.Id,
                Name = survey.SurveyName,
                ParticipateId = survey.Id,
                Created = survey.Created,
            };
            return response;
        }

        public Task UpdateSurveyAsync(UpdateExistingSurveyRequest request)
        {
            var updatedSurvey = new Survey
            {
                Id = request.Id,
                SurveyName = request.Name,
                Created = request.Created,
                ParticipantId = request.ParticipantId
            };
            return repository.UpdateAsync(updatedSurvey);
            
        }
    }
}
