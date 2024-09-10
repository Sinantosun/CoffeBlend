using CoffeBlend.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Interfaces.CategoryRepository
{
    public interface ICategoryRepository 
    {
        Task<List<Category>> GetRandom3CategoryAsync();
    }
}
