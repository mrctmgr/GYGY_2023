using Microsoft.AspNetCore.Mvc;
using SurveyAppMVC.Models;
using SurveyAppMVC.Services;
using SurveyAppMVCMVC.DTO_s.Requests.Answer;

namespace SurveyAppMVC.Controllers
{
    public class ResponseController : Controller
    {
        private readonly IAnswerService responseService;
        private readonly ISurveyService surveyService;
        private readonly IQuestionService questionService;
        public ResponseController(IAnswerService responseService, ISurveyService surveyService, IQuestionService questionService)
        {
            this.responseService = responseService;
            this.surveyService = surveyService;
            this.questionService = questionService;
        }

        public async Task<IActionResult> Index(int surveyId = 1)
        {
            var responses = await responseService.GetAllAnswersBySurveyIdAsync(surveyId);
            var survey = await surveyService.GetSurveyAsync(surveyId);
            var responseViewModel = new ViewModel
            {
                Responses = responses,
                Survey = survey
            };
            return View(responseViewModel);
        }

        public async Task<IActionResult> Graphic(int surveyId = 1)
        {
            var responses = await responseService.GetAllAnswersBySurveyIdAsync(surveyId);
            var survey = await surveyService.GetSurveyAsync(surveyId);
            var questions = await questionService.GetAllQuestionsBySurveyIdAsync(surveyId);
            var graphicViewModel = new ViewModel
            {
                Questions = questions,
                Responses = responses,
                Survey = survey
            };
            return View(graphicViewModel);

        }


        [HttpPost]
        public async Task<IActionResult> Submit([FromBody] CreateNewAnswerRequest request)
        {
            if (ModelState.IsValid)
            {
                await responseService.CreateAnswersAsync(request);
                return Json(request);
            }
            return BadRequest(ModelState.Keys.SelectMany(key => ModelState[key].Errors));

        }
    }
}
