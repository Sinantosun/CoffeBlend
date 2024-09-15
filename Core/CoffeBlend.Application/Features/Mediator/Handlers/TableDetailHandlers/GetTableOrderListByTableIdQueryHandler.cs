using CoffeBlend.Application.Features.Mediator.Queries.TableDetailQueries;
using CoffeBlend.Application.Features.Mediator.Results.TableDetailResults;
using CoffeBlend.Application.Interfaces.TableDetailRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.TableDetailHandlers
{
    public class GetTableOrderListByTableIdQueryHandler : IRequestHandler<GetTableOrderListByTableIdQuery, List<GetTableOrderListByTableIdQueryResult>>
    {
        private readonly ITableDetailRepository _repository;

        public GetTableOrderListByTableIdQueryHandler(ITableDetailRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTableOrderListByTableIdQueryResult>> Handle(GetTableOrderListByTableIdQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetTableOrderListByTableIdAsync(request.Id);
          
        }
    }
}
