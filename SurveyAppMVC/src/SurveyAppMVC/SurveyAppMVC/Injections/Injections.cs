using Microsoft.EntityFrameworkCore;
using SurveyAppMVC.Infrastructure.Repository;
using SurveyAppMVC.Services;
using SurveyAppMVCMVC.Infrastructure.Data;

namespace SurveyAppMVC.Injections
{
    public static class Injections
    {
        public static IServiceCollection AddInjections(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<IParticipantService, ParticipantService>();
            services.AddScoped<IParticipantRepository, EFParticipantRepository>();
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<IQuestionRepository, EFQuestionRepository>();
            services.AddScoped<IAnswerService, AnswerService>();
            services.AddScoped<IAnswerRepository, EFAnswerRepository>();
            services.AddScoped<ISurveyService, SurveyService>();
            services.AddScoped<ISurveyRepository, EFSurveyRepository>();

            services.AddDbContext<SurveyDbContext>(opt => opt.UseSqlServer(connectionString));

            return services;
        }
    }
}
