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
            List<GetProductListWithCategoryQueryResult> productList = new List<GetProductListWithCategoryQueryResult>();
            var value = await _productRepository.GetProductListWithCategoryAsync();
            foreach (var item in value)
            {
                GetCategoryQueryResult category = new GetCategoryQueryResult();
                category.Name = item.Category.Name;
                category.CategoryId = item.CategoryId;
                productList.Add(new GetProductListWithCategoryQueryResult
                {
                    ImageURL = item.ImageURL,

                    Category = category,
                    Description = item.Description,
                    Price = item.Price,
                    ProductId = item.ProductId,
                    ShortDescription = item.ShortDescription,
                    Title = item.Title

                });
            }
            return productList;


        }
    }
}
