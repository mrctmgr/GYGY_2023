using Microsoft.AspNetCore.Mvc;

namespace MovieFlix.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
