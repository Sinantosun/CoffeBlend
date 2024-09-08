using CoffeBlend.Application.Features.Mediator.Queries.ProductQueries;
using CoffeBlend.Application.Features.Mediator.Results.CategoryResults;
using CoffeBlend.Application.Features.Mediator.Results.ProductResults;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Application.Interfaces.ProductInterfaces;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.ProductHandlers
{
    public class GetProductListWithCategoryQueryHandler : IRequestHandler<GetProductListWithCategoryQuery, List<GetProductListWithCategoryQueryResult>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductListWithCategoryQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<GetProductListWithCategoryQueryResult>> Handle(GetProductListWithCategoryQuery request, CancellationToken cancellationToken)
        {
            var value = await _productRepository.GetProductListWithCategoryAsync();
            return value.Select(t => new GetProductListWithCategoryQueryResult
            {
                ImageURL=t.ImageURL,

                CategoryId = t.CategoryId,
                CategoryName = t.Category.Name,
                Description=t.Description,
                Price = t.Price,
                ProductId = t.ProductId,
                ShortDescription = t.ShortDescription,
                Title = t.Title 
            }).ToList();
           

        }
    }
}
