using Microsoft.AspNetCore.Mvc;

namespace MovieFlix.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
