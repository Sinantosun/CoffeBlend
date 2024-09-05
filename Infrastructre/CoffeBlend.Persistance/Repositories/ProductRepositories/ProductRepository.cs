using CoffeBlend.Application.Interfaces.ProductInterfaces;
using CoffeBlend.Domain.Entites;
using CoffeBlend.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Persistance.Repositories.ProductRepositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly CoffeBlendContext _context;

        public ProductRepository(CoffeBlendContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetProductListWithCategoryAsync()
        {
            var value = await _context.Products.Include(t=>t.Category).ToListAsync();
            return value;
        }
    }
}
