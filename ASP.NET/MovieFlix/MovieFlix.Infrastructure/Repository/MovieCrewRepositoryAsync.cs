using MovieFlix.Core.Contracts.Repository;
using MovieFlix.Core.Entities;
using MovieFlix.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFlix.Infrastructure.Repository
{
    public class MovieCrewRepositoryAsync : BaseRepositoryAsync<MovieCrew>, IMovieCrewRepositoryAsync
    {
        public MovieCrewRepositoryAsync(MovieFlixDbContext DbContext) : base(DbContext)
        {
        }
    }
}
