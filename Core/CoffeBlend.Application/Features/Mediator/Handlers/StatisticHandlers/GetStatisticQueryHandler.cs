using CoffeBlend.Application.Features.Mediator.Queries.StatisticQueries;
using CoffeBlend.Application.Features.Mediator.Results.StatisticResults;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.StatisticHandlers
{
    public class GetStatisticQueryHandler : IRequestHandler<GetStatisticQuery, List<GetStatisticQueryResult>>
    {
        private readonly IRepository<Statistic> _repository;

        public GetStatisticQueryHandler(IRepository<Statistic> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetStatisticQueryResult>> Handle(GetStatisticQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetListAsync();
            return values.Select(t => new GetStatisticQueryResult
            {
                Amount = t.Amount,
                StatisticId = t.StatisticId,
                Icon = t.Icon,
                Title = t.Title,

            }).ToList();
        }
    }
}
