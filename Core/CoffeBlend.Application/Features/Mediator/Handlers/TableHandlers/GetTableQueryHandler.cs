using CoffeBlend.Application.Features.Mediator.Queries.TableQueries;
using CoffeBlend.Application.Features.Mediator.Results.TableResults;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.TableHandlers
{
    public class GetTableQueryHandler : IRequestHandler<GetTableQuery, List<GetTableQueryResult>>
    {
        private readonly IRepository<Table> _repository;

        public GetTableQueryHandler(IRepository<Table> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTableQueryResult>> Handle(GetTableQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetListAsync();
            var values2 = values.OrderBy(t => t.TableID).ToList();
            return values2.Select(t => new GetTableQueryResult
            {
                TableID=t.TableID,
                Name = t.Name,
                Status = t.Status,
                Capacity=t.Capacity,
                

            }).ToList();
        }
    }
}
