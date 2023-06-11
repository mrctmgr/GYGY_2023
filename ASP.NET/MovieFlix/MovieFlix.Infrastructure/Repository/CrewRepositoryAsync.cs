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
    public class CrewRepositoryAsync : BaseRepositoryAsync<Crew>, ICrewRepositoryAsync
    {
        public CrewRepositoryAsync(MovieFlixDbContext DbContext) : base(DbContext)
        {
        }
    }
}
