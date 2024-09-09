using CoffeBlend.Application.Features.Mediator.Queries.ProductPricingQueries;
using CoffeBlend.Application.Features.Mediator.Results.ProductPricingResults;
using CoffeBlend.Application.Interfaces.ProductPricingRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.ProductPricingHandlers
{
    public class GetProductPricingByProductIdQueryHandler : IRequestHandler<GetProductPricingByProductIdQuery, List<GetProductPricingByProductIdQueryResult>>
    {
        private readonly IProductPricingRepository _productPricingRepository;

        public GetProductPricingByProductIdQueryHandler(IProductPricingRepository productPricingRepository)
        {
            _productPricingRepository = productPricingRepository;
        }

        public async Task<List<GetProductPricingByProductIdQueryResult>> Handle(GetProductPricingByProductIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _productPricingRepository.GetProductPricingByProductIdAsync(request.Id);
            return values.Select(y => new GetProductPricingByProductIdQueryResult
            {
                PricingTitle=y.Pricing.Name,
                Amount = y.Amount,
                PricingId = y.PricingId,
                ProductId = y.ProductId,
                ProductName=y.Product.Title,
                ProductPricingId=y.ProductPricingId,
            }).ToList();
        }
    }
}
