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
    public class GetProductPriceByProductIdQueryHandler : IRequestHandler<GetProductPriceByProductIdQuery, GetProductPriceByProductIdQueryResult>
    {
        private readonly IProductRepository _productRepository;

        public GetProductPriceByProductIdQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<GetProductPriceByProductIdQueryResult> Handle(GetProductPriceByProductIdQuery request, CancellationToken cancellationToken)
        {
          return await _productRepository.GetProductPriceByProductIdQuery(request.Id);
        }
    }
}
