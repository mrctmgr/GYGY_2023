using Microsoft.EntityFrameworkCore;
using SurveyAppMVC.Entities;
using SurveyAppMVCMVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVCMVC.Infrastructure.Data
{
    public class SurveyDbContext : DbContext
    {
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Answer> Answers { get; set; }

        public SurveyDbContext(DbContextOptions<SurveyDbContext> options) : base(options)
        {
        }
    }
}
