using MovieFlix.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFlix.Core.Contracts.Service
{
    public interface ICastServiceAsync
    {
        Task<int> InsertCastAsync(CastModel model);
        Task<int> UpdateCastAsync(CastModel model);
        Task<int> DeleteCastAsync(int Id);
        Task<CastModel> GetCastByIdAsync(int Id);
        Task<IEnumerable<CastModel>> GetAllCastsAsync();
    }
}
