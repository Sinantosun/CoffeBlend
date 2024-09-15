using CoffeBlend.Application.Features.Mediator.Queries.ReservationQueries;
using CoffeBlend.Application.Features.Mediator.Results.ReservationResults;
using CoffeBlend.Application.Interfaces.ReservationRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.ReservationHandlers
{
    public class GetLast7ReservationQueryHandler : IRequestHandler<GetLast7ReservationQuery, List<GetLast7ReservationQueryResult>>
    {
        private readonly IReservationRepository _repository;

        public GetLast7ReservationQueryHandler(IReservationRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLast7ReservationQueryResult>> Handle(GetLast7ReservationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetLast7ReservationAsync();
            return values.Select(t => new GetLast7ReservationQueryResult
            {
                Date = t.Date,
                Email = t.Email,
                NameSurname = t.NameSurname,
                Status = t.Status,
                TableName = t.Table.Name,
                ReservationId = t.ReservationId
            }).ToList();
        }
    }
}
