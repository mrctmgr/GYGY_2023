using SurveyAppMVC.DTO_s.Requests.Question;
using SurveyAppMVC.DTO_s.Responses.Question;
using SurveyAppMVC.Entities;
using SurveyAppMVC.Infrastructure.Repository;
using SurveyAppMVCMVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVC.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository repository;
        public QuestionService(IQuestionRepository repository)
        {
            this.repository = repository;
        }

        public async Task CreateQuestionAsync(CreateNewQuestionRequest request)
        {
            var question = new Question
            {
                QuestionText = request.Text,
                SurveyId = request.SurveyId,
                QuestionType = request.Type,
            };
            await repository.CreateAsync(question);
        }

        public async Task CreateQuestionsAsync(List<CreateNewQuestionRequest> request)
        {
            foreach (var questionRequest in request)
            {
                var question = new Question
                {
                    QuestionText = questionRequest.Text,
                    SurveyId = questionRequest.SurveyId,
                    QuestionType = questionRequest.Type,
                };
                await repository.CreateAsync(question);
            }
        }

        public async Task DeleteQuestionAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<QuestionDisplayResponse>> GetAllQuestionsAsync()
        {
            var questions = await repository.GetAllAsync();
            var responses = questions.Select(question => new QuestionDisplayResponse
            {
                Id = question.Id,
                Text = question.QuestionText,
                SurveyId = question.SurveyId,
                Type = question.QuestionType,
            });
            return responses;
        }

        public async Task<IEnumerable<QuestionDisplayResponse>> GetAllQuestionsBySurveyIdAsync(int surveyId)
        {
            var questions = await repository.GetAllAsync();
            var questionsBySurveyId = questions.Where(question => question.SurveyId == surveyId);
            var newQuestions = questionsBySurveyId.Select(newQuestion => new QuestionDisplayResponse
            {
                Id = newQuestion.Id,
                Text = newQuestion.QuestionText,
                SurveyId = newQuestion.SurveyId,
                Type = newQuestion.QuestionType,
            });
            return newQuestions;
        }

        public async Task<QuestionDisplayResponse> GetQuestionAsync(int id)
        {
            var question = await repository.GetAsync(id);
            var response = new QuestionDisplayResponse
            {
                Id = question.Id,
                Text = question.QuestionText,
                SurveyId = question.SurveyId,
                Type = question.QuestionType,
            };
            return response;
        }

        public async Task<QuestionDisplayResponse> GetQuestionBySurveyIdAsync(int surveyId)
        {
            var questions = await repository.GetAllAsync();
            var bySurvey = questions.FirstOrDefault(question => question.SurveyId == surveyId);
            var displayResponse = new QuestionDisplayResponse
            {
                Id = bySurvey.Id,
                Text = bySurvey.QuestionText,
                SurveyId = bySurvey.SurveyId,
                Type = bySurvey.QuestionType,
            };
            return displayResponse;
        }

        public Task UpdateQuestionAsync(UpdateExistingQuestionRequest request)
        {
            var updatedQuestion = new Question
            {
                Id = request.Id,
                QuestionText = request.Text,
                SurveyId = request.SurveyId,
                QuestionType = request.Type
            };
            return repository.UpdateAsync(updatedQuestion);
        }
    }
}
