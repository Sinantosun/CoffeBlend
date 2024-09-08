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
    public class GetCanceledReservationQueryHandler : IRequestHandler<GetCanceledReservationQuery, List<GetCanceledReservationQueryResult>>
    {
        private readonly IReservationRepository _reservationRepository;

        public GetCanceledReservationQueryHandler(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<List<GetCanceledReservationQueryResult>> Handle(GetCanceledReservationQuery request, CancellationToken cancellationToken)
        {
            var values = await _reservationRepository.GetCanceledReservationAsync();
            return values.Select(t => new GetCanceledReservationQueryResult
            {
                TableID = t.TableID,
                Date = t.Date,
                ReservationId = t.ReservationId,
                Email = t.Email,
                NameSurname = t.NameSurname,
                Phone = t.Phone,
                SpecialRequest = t.SpecialRequest,
                Status = t.Status

            }).ToList();
        }
    }
}
