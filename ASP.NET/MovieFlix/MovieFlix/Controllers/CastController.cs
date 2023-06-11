using Microsoft.AspNetCore.Mvc;
using MovieFlix.Core.Contracts.Service;
using MovieFlix.Core.Models;

namespace MovieFlix.Controllers
{
    public class CastController : Controller
    {
        private readonly ICastServiceAsync castServ;
        private readonly IMovieCastServiceAsync movieCastServ;

        public CastController (ICastServiceAsync castServ, IMovieCastServiceAsync movieCastServ)
        {
            this.castServ = castServ;
            this.movieCastServ = movieCastServ;
        }
        [HttpGet]
        public async Task<IActionResult> ShowAllMoviesByCast(int castId)
        {
            IEnumerable<MoviesByCastModel> moviesByCast = await movieCastServ.GetAllMoviesByCastId(castId);
            return View(moviesByCast);
        }

    }
}
