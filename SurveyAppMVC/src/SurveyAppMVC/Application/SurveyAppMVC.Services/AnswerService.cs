using SurveyAppMVC.DTO_s.Requests;
using SurveyAppMVC.DTO_s.Requests.Answer;
using SurveyAppMVC.DTO_s.Responses;
using SurveyAppMVC.DTO_s.Responses.Answer;
using SurveyAppMVC.Entities;
using SurveyAppMVC.Infrastructure.Repository;
using SurveyAppMVCMVC.DTO_s.Requests.Answer;
using SurveyAppMVCMVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVC.Services
{
    public class AnswerService : IAnswerService
    {
        private readonly IAnswerRepository repository;
        public AnswerService(IAnswerRepository repository)
        {
            this.repository = repository;
        }

        public async Task CreateAnswerAsync(CreateNewAnswerRequest request)
        {
            var answer = new Answer
            {
                SurveyId = request.SurveyId,
                AnswerText = request.Answers, 
                };
            await repository.CreateAsync(answer);
        }

        public Task CreateAnswersAsync(CreateNewAnswerRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAnswerAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<AnswerDisplayResponse>> GetAllAnswersAsync()
        {
            var answers = await repository.GetAllAsync();
            var displayResponses = answers.Select(answer => new AnswerDisplayResponse
            {
                Id = answer.Id,
                SurveyId = answer.SurveyId,
                Answer = answer.AnswerText
            });
            return displayResponses;
        }

        public async Task<IEnumerable<AnswerDisplayResponse>> GetAllAnswersBySurveyIdAsync(int surveyId)
        {
            var Answers = await repository.GetAllAsync();
            var responsesBySurveyId = Answers.Where(response => response.SurveyId == surveyId);
            var newAnswers = responsesBySurveyId.Select(newAnswers => new AnswerDisplayResponse
            {
                Id = newAnswers.Id,
                    SurveyId = newAnswers.SurveyId,
                    Answer = newAnswers.AnswerText
            });
            return newAnswers;

        }

        public async Task<AnswerDisplayResponse> GetAnswerAsync(int id)
        {
            var response = await repository.GetAsync(id);
            var displayResponse = new AnswerDisplayResponse
            {
                Id = response.Id,
                SurveyId = response.SurveyId,
                Answer = response.AnswerText,
            };
            return displayResponse;
        }

        public async Task<AnswerDisplayResponse> GetAnswerBySurveyIdAsync(int surveyId)
        {
            var responses = await repository.GetAllAsync();
            var survey = responses.FirstOrDefault(response => response.SurveyId == surveyId);
            var displayResponse = new AnswerDisplayResponse { Id = survey.Id, SurveyId = survey.SurveyId, Answer = survey.AnswerText };
            return displayResponse;
        }

        public Task UpdateResponseAsync(UpdateExistingAnswerRequest request)
        {
            var updatedAnswer = new Answer
            {
                Id = request.Id,
                AnswerText = request.Answers,
                SurveyId = request.SurveyId,
            };
            return repository.UpdateAsync(updatedAnswer);
        }

        public Task UpdateAnswerAsync(UpdateExistingAnswerRequest request)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<AnswerDisplayResponse>> IAnswerService.GetAllAnswersBySurveyIdAsync(int surveyId)
        {
            throw new NotImplementedException();
        }

        Task<AnswerDisplayResponse> IAnswerService.GetAnswerAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<AnswerDisplayResponse> IAnswerService.GetAnswerBySurveyIdAsync(int surveyId)
        {
            throw new NotImplementedException();
        }
    }
}
