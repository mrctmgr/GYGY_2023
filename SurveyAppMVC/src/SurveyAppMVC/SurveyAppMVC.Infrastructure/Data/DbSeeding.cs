using SurveyAppMVC.Entities;
using SurveyAppMVCMVC.Entities;
using SurveyAppMVCMVC.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVC.Infrastructure.Data
{
    public class DbSeeding
    {
        public DbSeeding() { }
        public static void SeedDatabase(SurveyDbContext dbContext)
        {
            SeedParticipantIsNotExist(dbContext);
            SeedSurveyIsNotExist(dbContext);
            SeedQuestionIsNotExist(dbContext);
            SeedAnswerIsNotExist(dbContext);
        }
        public static void SeedParticipantIsNotExist(SurveyDbContext dbContext)
        {
            if (!dbContext.Participants.Any())
            {
                var participant = new Participant
                {
                    Id = 1,
                    ParticipantName = "Participant1",
                    ParticipantSurname = "Participant1Surname",
                    ParticipantEmail = "participant1@gmail.com",
                    ParticipantPassword = "123456",
                    Role = "Admin"
                };
                dbContext.Participants.Add(dbContext.Participants.First());
                dbContext.SaveChanges();

            }
        }

        public static void SeedSurveyIsNotExist (SurveyDbContext dbContext)
        {
           if (!dbContext.Participants.Any())
            {
                var survew = new Survey { Id = 1, SurveyName = "Test Survey" };
                dbContext.Surveys.Add(survew); dbContext.SaveChanges();
            }
        }

        public static void SeedQuestionIsNotExist(SurveyDbContext dbContext)
        {
            if (!dbContext.Questions.Any())
            {
                var question = new List<Question>
                {
                    new() {QuestionText = "Test Question",
                        QuestionType = "radio",
                        SurveyId = 1},
                };
                dbContext.Questions.AddRange(question);
                dbContext.SaveChanges();
            }
        }

        public static void SeedAnswerIsNotExist(SurveyDbContext dbContext)
        {
            if (!dbContext.Answers.Any())
            {
                var Answers = new List<Answer>
                {
                    new() {AnswerText = "Test Answer",
                        QuestionId = 1,
                        SurveyId  = 1,
                        ParticipantId = 1,
                        }
                };
                dbContext.Answers.AddRange(Answers);
                dbContext.SaveChanges();
            }
        }
    }
}
