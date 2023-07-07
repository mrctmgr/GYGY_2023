using SurveyAppMVC.Entities;
using SurveyAppMVC.Infrastructure.Repository;
using SurveyAppMVCMVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppMVC.Infrastructure.Repository
{
    public interface IQuestionRepository : IRepository<Question>
    {
    }
}
