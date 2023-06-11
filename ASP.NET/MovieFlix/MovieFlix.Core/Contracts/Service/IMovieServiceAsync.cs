using MovieFlix.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFlix.Core.Contracts.Service
{
    public interface IMovieServiceAsync
    {
        Task<int> InsertMovieAsync(MovieModel model);
        Task<int> UpdateMovieAsync(MovieModel model);
        Task DeleteMovieAsync(int id);
        Task<MovieModel> GetMovieByIdAsync(int id);
        Task<IEnumerable<MovieModel>> GetAllMoviesAsync();

    }
}
