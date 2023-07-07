using SurveyAppMVC.DTO_s.Responses.Question;
using SurveyAppMVC.DTO_s.Responses.Survey;

namespace SurveyAppMVC.Models
{
    public class QDisplayModel
    {
        public IEnumerable<QuestionDisplayResponse> Questions { get; set; }
        public SurveyDisplayResponse Survey { get; set; }
    }
}
