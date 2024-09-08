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
    public class GetTableByIdQueryHandler : IRequestHandler<GetTableByIdQuery, GetTableByIdQueryResult>
    {
        private readonly IRepository<Table> _repository;

        public GetTableByIdQueryHandler(IRepository<Table> repository)
        {
            _repository = repository;
        }

        public async Task<GetTableByIdQueryResult> Handle(GetTableByIdQuery request, CancellationToken cancellationToken)
        {
           var value = await _repository.GetByIdAsync(request.Id);
            return new GetTableByIdQueryResult
            {
                Name = value.Name,
                Status = value.Status,
                TableID=value.TableID,
            };
        }
    }
}
