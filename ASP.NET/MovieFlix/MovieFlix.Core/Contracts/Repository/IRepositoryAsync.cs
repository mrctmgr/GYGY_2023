using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFlix.Core.Contracts.Repository
{
    public interface IRepositoryAsync<T> where T : class
    {
        Task<int> InsertAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<IEnumerable<T>>  GetAllAsync();
        Task<int> DeleteAsync(int id);
        Task<T> GetByIdAsync(int id);
    }
}
