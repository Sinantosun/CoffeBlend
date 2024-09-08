using CoffeBlend.Application.Features.Mediator.Queries.ProductPricingQueries;
using CoffeBlend.Application.Features.Mediator.Results.ProductPricingResults;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.ProductPricingHandlers
{
    public class GetProductPricingByIdQueryHandler : IRequestHandler<GetProductPricingByIdQuery, GetProductPricingByIdQueryResult>
    {
        private readonly IRepository<ProductPricing> _repository;

        public GetProductPricingByIdQueryHandler(IRepository<ProductPricing> repository)
        {
            _repository = repository;
        }

        public async Task<GetProductPricingByIdQueryResult> Handle(GetProductPricingByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetProductPricingByIdQueryResult
            {
                Amount = value.Amount,
                PricingId = value.PricingId,
                ProductId = value.ProductId,
                ProductPricingId = value.ProductPricingId
            };
        }
    }
}
