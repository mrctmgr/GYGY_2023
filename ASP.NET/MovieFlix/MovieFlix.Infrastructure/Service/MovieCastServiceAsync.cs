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
    public class MovieCastServiceAsync : IMovieCastServiceAsync
    {
        private readonly IMovieCastRepositoryAsync movieCastRep;
        private readonly ICastRepositoryAsync castRep;
        private readonly IMovieRepositoryAsync movieRep;

        public MovieCastServiceAsync (IMovieCastRepositoryAsync movieCastRep, ICastRepositoryAsync castRep, IMovieRepositoryAsync movieRep)
        {
            this.movieCastRep = movieCastRep;
            this.castRep = castRep;
            this.movieRep = movieRep;
        }

        public Task<int> DeleteMovieCastAsync(int Id)
        {
            return movieCastRep.DeleteAsync(Id);
        }

        public async Task<IEnumerable<MoviesByCastModel>> GetAllMoviesByCastId(int CastId)
        {
            var allMovieCasts = await movieCastRep.GetAllAsync();
            List<MoviesByCastModel> result = new List<MoviesByCastModel>();

            foreach (var movieCast in allMovieCasts)
            {
                if(movieCast.CastId == CastId)
                {
                    Cast cast = await castRep.GetByIdAsync(movieCast.CastId);
                    Movie movie = await movieRep.GetByIdAsync(movieCast.MovieId);

                    MoviesByCastModel moviesByCastModel = new MoviesByCastModel()
                    {
                        Name = cast.Name,
                        ProfilePath = cast.ProfilePath,
                        Character = movieCast.Character,
                        Title = movie.Title
                    };
                    result.Add(moviesByCastModel);
                }
            }
            return result;

        }

        public async Task<IEnumerable<MovieCastModel>> GetAllMovieCastByMovieId(int MovieId)
        {
            var allMovieCasts = await movieCastRep.GetAllAsync();
            List<MovieCastModel> result = new List<MovieCastModel>();
            

            foreach(var movieCast in allMovieCasts)
            {
                if (movieCast.MovieId == MovieId)
                {
                    Cast cast = await castRep.GetByIdAsync(movieCast.CastId);
                    MovieCastModel model = new MovieCastModel();
                    CastModel castModel = new CastModel()
                    {
                        Id = cast.Id,
                        Name = cast.Name,
                        Gender = cast.Gender,
                        TmdbUrl = cast.TmdbUrl,
                        ProfilePath = cast.ProfilePath,
                    };
                    model.Id = movieCast.Id;
                    model.CastId = movieCast.CastId;
                    model.MovieId = movieCast.Id;
                    model.Character = movieCast.Character;
                    model.Cast = castModel;
                    result.Add(model);
                }
            }
            return result;
        }

        public async Task<MovieCastModel> GetMovieCastByIdAsync(int Id)
        {
            var movie = await movieCastRep.GetByIdAsync(Id);
            MovieCastModel model = new MovieCastModel();
            model.Id = movie.Id;
            model.CastId = movie.CastId;
            model.MovieId = movie.Id;
            model.Character = movie.Character;
            return model;
        }

        public async Task<int> InsertMovieCastAsync(MovieCastModel model)
        {
            Cast cast = await castRep.GetByIdAsync(model.CastId);
            MovieCast movieCast = new MovieCast()
            {
                CastId = model.CastId,
                MovieId = model.MovieId,
                Character = model.Character,
                Cast = cast
            };
            
            return await movieCastRep.InsertAsync(movieCast);
        }

        public Task<int> UpdateMovieCastAsync(MovieCastModel model)
        {
            MovieCast movieCast = new MovieCast()
            {
                CastId = model.CastId,
                MovieId = model.Id,
                Character = model.Character,
            };

            return movieCastRep.UpdateAsync(movieCast);
        }
    }
}
