using Newtonsoft.Json.Linq;
using SurveyAppMVC.DTO_s.Responses.Answer;
using SurveyAppMVC.DTO_s.Responses.Survey;

namespace SurveyAppMVC.Models
{
    public class ADisplayModel
    {
        public IEnumerable<AnswerDisplayResponse> Responses { get; set; }
        public SurveyDisplayResponse Survey { get; set; }

        public int ResponseNumber()
        {
            var count = 0;
            foreach (var item in Responses)
            {
                string json = item.Answer;
                JArray jsonArray = JArray.Parse(json);
                count = jsonArray.Count;
                return count;
            }
            return count;
        }
    }
}
