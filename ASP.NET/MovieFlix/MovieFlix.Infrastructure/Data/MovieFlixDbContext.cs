using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Azure.Documents;
using Microsoft.EntityFrameworkCore;
using MovieFlix.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User = MovieFlix.Core.Entities.User;

namespace MovieFlix.Infrastructure.Data
{
    public class MovieFlixDbContext : IdentityDbContext<User>
    {
        public MovieFlixDbContext(DbContextOptions<MovieFlixDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<MovieGenre> MovieGenre { get; set; }
        public DbSet<MovieCrew> MovieCrew { get; set; }
        public DbSet<Crew> Crew { get; set; }
        public DbSet<MovieCast> MovieCast { get; set; }
        public DbSet<Cast> Cast { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<Trailer> Trailer { get; set; }

        
    }
}
