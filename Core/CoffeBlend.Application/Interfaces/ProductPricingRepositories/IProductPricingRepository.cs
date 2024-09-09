using CoffeBlend.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Interfaces.ProductPricingRepositories
{
    public interface IProductPricingRepository
    {
        Task<List<ProductPricing>> GetProductPricingByProductIdAsync(int ProductId);
    }
}
