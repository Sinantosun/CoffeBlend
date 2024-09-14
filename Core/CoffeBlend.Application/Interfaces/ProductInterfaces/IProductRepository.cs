using CoffeBlend.Application.Features.Mediator.Results.ProductResults;
using CoffeBlend.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Interfaces.ProductInterfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductListWithCategoryAsync();
        Task<List<Product>> GetLast5CoffeProductListAsync();
        Task<List<Product>> GetLast5ProductListAsync();

        Task<GetProductPriceByProductIdQueryResult> GetProductPriceByProductIdQuery(int id);


    }
}
