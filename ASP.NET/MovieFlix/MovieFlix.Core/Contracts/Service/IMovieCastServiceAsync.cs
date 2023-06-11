using MovieFlix.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFlix.Core.Contracts.Service
{
    public interface IMovieCastServiceAsync
    {
        Task<int> InsertMovieCastAsync(MovieCastModel model);
        Task<int> UpdateMovieCastAsync(MovieCastModel model);
        Task<int> DeleteMovieCastAsync(int Id);
        Task<MovieCastModel> GetMovieCastByIdAsync(int Id);

        Task<IEnumerable<MovieCastModel>> GetAllMovieCastByMovieId(int MovieId);
        Task<IEnumerable<MoviesByCastModel>> GetAllMoviesByCastId(int CastId);
    }
}
