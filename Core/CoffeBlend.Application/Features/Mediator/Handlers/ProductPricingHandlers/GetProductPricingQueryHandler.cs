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
    public class GetProductPricingQueryHandler : IRequestHandler<GetProductPricingQuery, List<GetProductPricingQueryResult>>
    {
        private readonly IRepository<ProductPricing> _repository;

        public GetProductPricingQueryHandler(IRepository<ProductPricing> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetProductPricingQueryResult>> Handle(GetProductPricingQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetListAsync();
            return values.Select(t => new GetProductPricingQueryResult
            {
                Amount = t.Amount,
                PricingId = t.PricingId,
                ProductId = t.ProductId,
                ProductPricingId = t.ProductPricingId,
                

            }).ToList();
        }
    }
}
