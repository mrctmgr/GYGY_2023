using Microsoft.AspNetCore.Mvc;
using SurveyAppMVC.Models;
using SurveyAppMVC.Services;

namespace SurveyAppMVC.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionService questionService;
        private readonly ISurveyService surveyService;
        public QuestionController(IQuestionService questionService, ISurveyService surveyService)
        {
            this.questionService = questionService;
            this.surveyService = surveyService;
        }

        public async Task<IActionResult> Index(int surveyId = 1)
        {
            var questions = await questionService.GetAllQuestionsBySurveyIdAsync(surveyId);
            var survey = await surveyService.GetSurveyAsync(surveyId);
            var questionsViewModel = new QDisplayModel
            {
                Questions = questions,
                Survey = survey
            };
            return View(questionsViewModel);
        }
    }
}
