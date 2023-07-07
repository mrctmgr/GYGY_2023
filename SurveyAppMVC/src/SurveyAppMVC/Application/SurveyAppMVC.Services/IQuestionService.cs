using SurveyAppMVC.DTO_s.Requests.Question;
using SurveyAppMVC.DTO_s.Responses.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVC.Services
{
    public interface IQuestionService
    {
        Task<QuestionDisplayResponse> GetQuestionAsync(int id);
        Task<IEnumerable<QuestionDisplayResponse>> GetAllQuestionsAsync();
        Task<IEnumerable<QuestionDisplayResponse>> GetAllQuestionsBySurveyIdAsync(int surveyId);
        Task<QuestionDisplayResponse> GetQuestionBySurveyIdAsync(int surveyId);
        Task CreateQuestionAsync(CreateNewQuestionRequest request);
        Task CreateQuestionsAsync(List<CreateNewQuestionRequest> request);  
        Task DeleteQuestionAsync(int id);
        Task UpdateQuestionAsync(UpdateExistingQuestionRequest request);
    }
}
