using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Interfaces.GenericRepository
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetListAsync();    
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(int id);
   
    }
}
