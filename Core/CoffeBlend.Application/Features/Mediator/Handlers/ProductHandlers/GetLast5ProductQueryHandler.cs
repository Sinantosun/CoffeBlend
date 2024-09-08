using CoffeBlend.Application.Features.Mediator.Queries.ProductQueries;
using CoffeBlend.Application.Features.Mediator.Results.ProductResults;
using CoffeBlend.Application.Interfaces.ProductInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.ProductHandlers
{
    public class GetLast5ProductQueryHandler : IRequestHandler<GetLast5ProductQuery, List<GetLast5ProductQueryResult>>
    {
        private readonly IProductRepository _productRepository;

        public GetLast5ProductQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<GetLast5ProductQueryResult>> Handle(GetLast5ProductQuery request, CancellationToken cancellationToken)
        {
            var values = await _productRepository.GetLast5ProductListAsync();
            return values.Select(t => new GetLast5ProductQueryResult
            {
                CategoryId = t.CategoryId,
                ProductId = t.ProductId,
                CategoryName = t.Category.Name,
                Description = t.Description,
                ImageURL = t.ImageURL,
                Price = t.Price,
                ShortDescription = t.ShortDescription,
                Title = t.Title,
            }).ToList();
        }
    }
}
