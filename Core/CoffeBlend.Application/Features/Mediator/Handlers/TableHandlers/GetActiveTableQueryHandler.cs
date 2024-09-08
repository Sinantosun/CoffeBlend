using CoffeBlend.Application.Features.Mediator.Queries.TableQueries;
using CoffeBlend.Application.Features.Mediator.Results.TableResults;
using CoffeBlend.Application.Interfaces.TableRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.TableHandlers
{
    public class GetActiveTableQueryHandler : IRequestHandler<GetActiveTableQuery, List<GetActiveTableQueryResult>>
    {
        private readonly ITableRepository _repository;

        public GetActiveTableQueryHandler(ITableRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetActiveTableQueryResult>> Handle(GetActiveTableQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetActiveTableList();
            return values.Select(t => new GetActiveTableQueryResult
            {
                Name = t.Name,
                TableID = t.TableID,
            }).ToList();
        }
    }
}
