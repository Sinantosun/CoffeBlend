using CoffeBlend.Application.Interfaces.CategoryRepository;
using CoffeBlend.Domain.Entites;
using CoffeBlend.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Persistance.Repositories.CategoryRepositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CoffeBlendContext _context;

        public CategoryRepository(CoffeBlendContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetRandom3CategoryAsync()
        {
            var values = await _context.Categories.OrderByDescending(t => Guid.NewGuid()).Take(3).ToListAsync();
            return values;  
        }
    }
}
