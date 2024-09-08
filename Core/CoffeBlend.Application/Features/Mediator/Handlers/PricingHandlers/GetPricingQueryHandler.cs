using CoffeBlend.Application.Features.Mediator.Queries.PricingQueries;
using CoffeBlend.Application.Features.Mediator.Results.PricingResults;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.PricingHandlers
{
    public class GetPricingQueryHandler : IRequestHandler<GetPricingQuery, List<GetPricingQueryResult>>
    {
        private readonly IRepository<Pricing> _repository;

        public GetPricingQueryHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetPricingQueryResult>> Handle(GetPricingQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetListAsync();
            return values.Select(t => new GetPricingQueryResult
            {
                Name = t.Name,
                PricingId = t.PricingId,
            }).ToList();
        }
    }
}
