using CoffeBlend.Application.Features.Mediator.Queries.ReservationQueries;
using CoffeBlend.Application.Features.Mediator.Results.ReservationResults;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.ReservationHandlers
{
    public class GetReservationQueryHandler : IRequestHandler<GetReservationQuery, List<GetReservationQueryResult>>
    {
        private readonly IRepository<Reservation> _repository;

        public GetReservationQueryHandler(IRepository<Reservation> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetReservationQueryResult>> Handle(GetReservationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetListAsync();
            return values.Select(t => new GetReservationQueryResult
            {
                TableID = t.TableID,
                Date = t.Date,
                ReservationId = t.ReservationId,
                Email = t.Email,
                NameSurname = t.NameSurname,
                Phone = t.Phone,
                SpecialRequest = t.SpecialRequest,
                Status = t.Status,
            }).ToList();
        }
    }
}
