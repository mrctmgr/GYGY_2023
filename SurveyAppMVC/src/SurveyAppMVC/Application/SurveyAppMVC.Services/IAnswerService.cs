using SurveyAppMVC.DTO_s.Requests.Question;
using SurveyAppMVC.DTO_s.Requests;
using SurveyAppMVC.DTO_s.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveyAppMVC.DTO_s.Responses.Answer;
using SurveyAppMVCMVC.DTO_s.Requests.Answer;
using SurveyAppMVC.DTO_s.Requests.Answer;

namespace SurveyAppMVC.Services
{
    public interface IAnswerService
    {
        Task<AnswerDisplayResponse> GetAnswerAsync(int id);
        Task<AnswerDisplayResponse> GetAnswerBySurveyIdAsync(int surveyId);
        Task<IEnumerable<AnswerDisplayResponse>> GetAllAnswersAsync();
        Task<IEnumerable<AnswerDisplayResponse>> GetAllAnswersBySurveyIdAsync(int surveyId);
        Task CreateAnswersAsync(CreateNewAnswerRequest request);
        Task DeleteAnswerAsync(int id);
        Task UpdateAnswerAsync(UpdateExistingAnswerRequest request);
    }
}
