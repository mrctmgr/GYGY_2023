using Newtonsoft.Json.Linq;
using SurveyAppMVC.DTO_s.Responses.Answer;
using SurveyAppMVC.DTO_s.Responses.Question;
using SurveyAppMVC.DTO_s.Responses.Survey;

namespace SurveyAppMVC.Models
{
    public class ViewModel
    {
        public IEnumerable<AnswerDisplayResponse> Responses { get; set; }
        public SurveyDisplayResponse Survey { get; set; }
        public IEnumerable<QuestionDisplayResponse> Questions { get; set; }
        public List<string> ResponsesByQuestionId(int questionId)
        {
            List<string> questionIds = new List<string>();
            foreach (var item in Responses)
            {
                string json = item.Answer;
                JArray jsonArray = JArray.Parse(json);
                foreach (var obj in jsonArray)
                {
                    if (obj["id"].ToString() == questionId.ToString())
                    {
                        questionIds.Add(obj["answer"].ToString());
                    }
                }
            }
            return questionIds;
        }

        public Dictionary<string, int> CountEachResponses(int questionId)
        {
            var newList = new Dictionary<string, int>();
            var responseList = ResponsesByQuestionId(questionId);
            var groups = responseList.GroupBy(item => item)
                                     .Select(group => new { Value = group.Key, Count = group.Count() });
            foreach (var group in groups)
            {
                newList.Add(group.Value, group.Count);
            }
            return newList;
        }
    }
}
