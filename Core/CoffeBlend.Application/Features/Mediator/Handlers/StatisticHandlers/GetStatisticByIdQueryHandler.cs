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
    public class GetStatisticByIdQueryHandler : IRequestHandler<GetStatisticByIdQuery, GetStatisticByIdQueryResult>
    {
        private readonly IRepository<Statistic> _repository;

        public GetStatisticByIdQueryHandler(IRepository<Statistic> repository)
        {
            _repository = repository;
        }

        public async Task<GetStatisticByIdQueryResult> Handle(GetStatisticByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetStatisticByIdQueryResult
            {
                Amount = values.Amount,
                Icon = values.Icon,
                StatisticId = values.StatisticId,
                Title = values.Title    
            };
        }
    }
}
