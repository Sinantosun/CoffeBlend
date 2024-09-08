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
    public class GetApprovedReservationQueryHandler : IRequestHandler<GetApprovedReservationQuery, List<GetApprovedReservationQueryResult>>
    {
        private readonly IReservationRepository _reservationRepository;

        public GetApprovedReservationQueryHandler(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<List<GetApprovedReservationQueryResult>> Handle(GetApprovedReservationQuery request, CancellationToken cancellationToken)
        {
            var values = await _reservationRepository.GetApprovedReservationAsync();
            return values.Select(t => new GetApprovedReservationQueryResult
            {
                TableID = t.TableID,
                Date = t.Date,
                Email = t.Email,
                ReservationId = t.ReservationId,
                NameSurname = t.NameSurname,
                Phone = t.Phone,
                SpecialRequest = t.SpecialRequest,
                Status = t.Status,

            }).ToList();
        }
    }
}
