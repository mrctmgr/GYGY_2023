using Microsoft.EntityFrameworkCore;
using SurveyAppMVCMVC.Entities;
using SurveyAppMVCMVC.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVC.Infrastructure.Repository
{
    public class EFSurveyRepository : ISurveyRepository
    {
        private readonly SurveyDbContext context;
        public EFSurveyRepository(SurveyDbContext context)
        {
            this.context = context;
        }

        public async Task CreateAsync(Survey survey)
        {
            await context.Surveys.AddAsync(survey);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deletingSurvey = await context.Surveys.FindAsync(id);
            if (deletingSurvey != null)
            {
                context.Surveys.Remove(deletingSurvey);
            }
            await context.SaveChangesAsync();
        }

        public async Task<List<Survey>> GetAllAsync()
        {
            return await context.Surveys.AsNoTracking().ToListAsync();
        }

        public async Task<Survey> GetAsync(int id)
        {
            return await context.Surveys.AsNoTracking().FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task UpdateAsync(Survey survey)
        {
            context.Surveys.Update(survey);
            await context.SaveChangesAsync();
        }
    }
}
