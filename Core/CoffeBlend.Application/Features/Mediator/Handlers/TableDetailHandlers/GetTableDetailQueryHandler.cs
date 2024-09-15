using CoffeBlend.Application.Features.Mediator.Queries.TableDetailQueries;
using CoffeBlend.Application.Features.Mediator.Results.TableDetailResults;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.TableDetailHandlers
{
    public class GetTableDetailQueryHandler : IRequestHandler<GetTableDetailQuery, List<GetTableDetailQueryResult> >
    {
        private readonly IRepository<TableDetail> _repository;

        public GetTableDetailQueryHandler(IRepository<TableDetail> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTableDetailQueryResult>> Handle(GetTableDetailQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetListAsync();
            return values.Select(t => new GetTableDetailQueryResult
            {
                ProductId = t.ProductId,
                Quantity = t.Quantity,
                TableDetailID = t.TableDetailID,
                TableID = t.TableID,
                UnitPrice = t.UnitPrice
            }).ToList();
        }
    }
}
