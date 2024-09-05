using CoffeBlend.Application.Features.Mediator.Queries.FeatureQueries;
using CoffeBlend.Application.Features.Mediator.Results.FeatureResults;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.FeatureHandlers
{

    public class GetFeatureQueryHandler : IRequestHandler<GetFeatureQuery, List<GetFeatureQueryResult>>
    {
        private readonly IRepository<Feature> _repository;

        public GetFeatureQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFeatureQueryResult>> Handle(GetFeatureQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetListAsync();
            return value.Select(t => new GetFeatureQueryResult
            {
                Description = t.Description,
                FeatureId = t.FeatureId,
                Image = t.Image,
                Title = t.Title,
            }).ToList();
        }
    }
}
