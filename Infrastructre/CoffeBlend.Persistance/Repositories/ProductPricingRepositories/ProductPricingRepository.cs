using CoffeBlend.Application.Interfaces.ProductPricingRepositories;
using CoffeBlend.Domain.Entites;
using CoffeBlend.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Persistance.Repositories.ProductPricingRepositories
{
    public class ProductPricingRepository : IProductPricingRepository
    {
        private readonly CoffeBlendContext _context;

        public ProductPricingRepository(CoffeBlendContext context)
        {
            _context = context;
        }

        public async Task<List<ProductPricing>> GetProductPricingByProductIdAsync(int ProductId)
        {
            var values = await _context.ProductPricings.Where(t => t.ProductId == ProductId).Include(t => t.Product).Include(t=>t.Pricing).ToListAsync();
            return values;
        }
    }
}
