using Microsoft.EntityFrameworkCore;
using SurveyAppMVC.Entities;
using SurveyAppMVC.Infrastructure.Data;
using SurveyAppMVCMVC.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVC.Infrastructure.Repository
{
    public class EFParticipantRepository : IParticipantRepository
    {
        private readonly SurveyDbContext context;
        public EFParticipantRepository(SurveyDbContext context)
        {
            this.context = context;
        }

        public async Task CreateAsync(Participant participant)
        {
            await context.Participants.AddAsync(participant);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deletingParticipant = await context.Participants.FindAsync(id);
            if (deletingParticipant != null)
            {
                context.Participants.Remove(deletingParticipant);
            }
            await context.SaveChangesAsync();
        }

        public async Task<List<Participant>> GetAllAsync()
        {
            return await context.Participants.AsNoTracking().ToListAsync();
        }

        public async Task<Participant> GetAsync(int id)
        {
            return await context.Participants.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task UpdateAsync(Participant participant)
        {
            context.Participants.Update(participant);
            await context.SaveChangesAsync();
        }
    }
}
