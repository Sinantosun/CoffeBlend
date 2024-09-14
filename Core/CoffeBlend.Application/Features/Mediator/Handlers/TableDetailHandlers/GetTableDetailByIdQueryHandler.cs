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
    public class GetTableDetailByIdQueryHandler : IRequestHandler<GetTableDetailByIdQuery, GetTableDetailByIdQueryResult>
    {
        private readonly IRepository<TableDetail> _repository;

        public GetTableDetailByIdQueryHandler(IRepository<TableDetail> repository)
        {
            _repository = repository;
        }

        public async Task<GetTableDetailByIdQueryResult> Handle(GetTableDetailByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetTableDetailByIdQueryResult
            {
                ProductId  = value.ProductId,
                Quantity = value.Quantity,
                TableDetailID = value.TableDetailID,
                TableID = value.TableID,
                UnitPrice = value.UnitPrice
            };
        }
    }
}
