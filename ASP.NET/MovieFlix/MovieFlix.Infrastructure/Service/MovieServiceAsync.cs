using MovieFlix.Core.Contracts.Repository;
using MovieFlix.Core.Contracts.Service;
using MovieFlix.Core.Entities;
using MovieFlix.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFlix.Infrastructure.Service
{
    

    public class MovieServiceAsync : IMovieServiceAsync
    {
        private readonly IMovieRepositoryAsync movieRep;

        public MovieServiceAsync(IMovieRepositoryAsync movieRep)
        {
            this.movieRep = movieRep;
        }
        public Task DeleteMovieAsync(int id)
        {
           return movieRep.DeleteAsync(id);
        }

        public async Task<IEnumerable<MovieModel>> GetAllMoviesAsync()
        {
            var allMovies = await movieRep.GetAllAsync();
            List<MovieModel> movies = new List<MovieModel>();
            foreach (var movie in allMovies)
            {
                MovieModel movieModel = new MovieModel()
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Overview = movie.Overview,
                    Tagline = movie.Tagline,
                    Budget = movie.Budget,
                    Revenue = movie.Revenue,
                    ImdbUrl = movie.ImdbUrl,
                    TmdbUrl = movie.TmdbUrl,
                    PosterUrl = movie.PosterUrl,
                    BackdropUrl = movie.BackdropUrl,
                    OriginalLanguage = movie.OriginalLanguage,
                    ReleaseDate = movie.ReleaseDate,
                    RunTime = movie.RunTime,
                    Price = movie.Price,
                    CreatedBy = movie.CreatedBy,
                    UpdatedBy = movie.UpdatedBy,
                    UpdatedDate = movie.UpdatedDate,
                    CreatedDate = movie.CreatedDate,

                };
                movies.Add(movieModel);

            }
            return movies;
        }

        public async Task<MovieModel> GetMovieByIdAsync(int id)
        {
            var movie = await movieRep.GetByIdAsync(id);
            if(movie != null)
            {

                MovieModel movieModel = new MovieModel()
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Overview = movie.Overview,
                    Tagline = movie.Tagline,
                    Budget = movie.Budget,
                    Revenue = movie.Revenue,
                    ImdbUrl = movie.ImdbUrl,
                    TmdbUrl = movie.TmdbUrl,
                    PosterUrl = movie.PosterUrl,
                    BackdropUrl = movie.BackdropUrl,
                    OriginalLanguage = movie.OriginalLanguage,
                    ReleaseDate = movie.ReleaseDate,
                    RunTime = movie.RunTime,
                    Price = movie.Price,
                    CreatedBy = movie.CreatedBy,
                    UpdatedBy = movie.UpdatedBy,
                    UpdatedDate = movie.UpdatedDate,
                    CreatedDate = movie.CreatedDate,

                };
                return movieModel;
            }
            return null;


        }

        public Task<int> InsertMovieAsync(MovieModel model)
        {
            Movie movie = new Movie()
            {
                Title = model.Title,
                Overview = model.Overview,
                Tagline = model.Tagline,
                Budget = model.Budget,
                Revenue = model.Revenue,
                ImdbUrl = model.ImdbUrl,
                TmdbUrl = model.TmdbUrl,
                PosterUrl = model.PosterUrl,
                BackdropUrl = model.BackdropUrl,
                OriginalLanguage = model.OriginalLanguage,
                ReleaseDate = model.ReleaseDate,
                RunTime = model.RunTime,
                Price = model.Price,
                CreatedBy = model.CreatedBy,
                UpdatedBy = model.UpdatedBy,
                UpdatedDate = model.UpdatedDate,
                CreatedDate = model.CreatedDate,
            };
            return movieRep.InsertAsync(movie);
        }

        public Task<int> UpdateMovieAsync(MovieModel model)
        {
            Movie movie = new Movie()
            {
                Id = model.Id,
                Title = model.Title,
                Overview = model.Overview,
                Tagline = model.Tagline,
                Budget = model.Budget,
                Revenue = model.Revenue,
                ImdbUrl = model.ImdbUrl,
                TmdbUrl = model.TmdbUrl,
                PosterUrl = model.PosterUrl,
                BackdropUrl = model.BackdropUrl,
                OriginalLanguage = model.OriginalLanguage,
                ReleaseDate = model.ReleaseDate,
                RunTime = model.RunTime,
                Price = model.Price,
                CreatedBy = model.CreatedBy,
                UpdatedBy = model.UpdatedBy,
                UpdatedDate = model.UpdatedDate,
                CreatedDate = model.CreatedDate,
            };
            return movieRep.UpdateAsync(movie);

        }
    }
}
