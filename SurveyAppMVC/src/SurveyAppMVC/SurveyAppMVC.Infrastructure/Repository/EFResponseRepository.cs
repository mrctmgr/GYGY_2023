using Microsoft.EntityFrameworkCore;
using SurveyAppMVC.Entities;
using SurveyAppMVC.Infrastructure.Data;
using SurveyAppMVCMVC.Entities;
using SurveyAppMVCMVC.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVC.Infrastructure.Repository
{
    public class EFAnswerRepository : IAnswerRepository
    {
        private readonly SurveyDbContext context;
        public EFAnswerRepository(SurveyDbContext context)
        {
            this.context = context;
        }

        public async Task CreateAsync(Answer answer)
        {
            await context.Answers.AddAsync(answer);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deletingAnswer = await context.Answers.FindAsync(id);
            if (deletingAnswer != null)
            {
                context.Answers.Remove(deletingAnswer);
            }
            await context.SaveChangesAsync();
        }

        public async Task<List<Answer>> GetAllAsync()
        {
            return await context.Answers.AsNoTracking().ToListAsync();
        }

        public async Task<Answer> GetAsync(int id)
        {
            return await context.Answers.AsNoTracking().FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task UpdateAsync(Answer answer)
        {
            context.Answers.Update(answer);
            await context.SaveChangesAsync();
        }
    }
}
