using SurveyAppMVC.DTO_s.Requests.Survey;
using SurveyAppMVC.DTO_s.Responses.Survey;
using SurveyAppMVC.Entities;
using SurveyAppMVCMVC.DTO_s.Requests.Survey;
using SurveyAppMVCMVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVC.Services
{
    public interface ISurveyService
    {
        Task<SurveyDisplayResponse> GetSurveyAsync(int id);
        Task<IEnumerable<SurveyDisplayResponse>> GetAllSurveysAsync();
        Task<Survey> CreateSurveyAsync(CreateNewSurveyRequest request);
        Task DeleteSurveyAsync(int id);
        Task UpdateSurveyAsync(UpdateExistingSurveyRequest request);
    }
}
