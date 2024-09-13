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
    public class GetDeactiveTableQueryHandler : IRequestHandler<GetDeactiveTableQuery, List<GetDeactiveTableQueryResult>>
    {
        private readonly ITableRepository _repository;

        public GetDeactiveTableQueryHandler(ITableRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetDeactiveTableQueryResult>> Handle(GetDeactiveTableQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetDeactiveTableList();
            return values.Select(t => new GetDeactiveTableQueryResult
            {
                Name = t.Name,
                TableID=t.TableID,
            }).ToList();
        }
    }
}
