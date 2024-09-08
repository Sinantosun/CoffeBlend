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
    public class GetConfirmationReservationQueryHandler : IRequestHandler<GetConfirmationReservationQuery, List<GetConfirmationReservationQueryResult>>
    {
        private readonly IReservationRepository _reservationRepository;

        public GetConfirmationReservationQueryHandler(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<List<GetConfirmationReservationQueryResult>> Handle(GetConfirmationReservationQuery request, CancellationToken cancellationToken)
        {
            var values = await _reservationRepository.GetConfirmationReseravtionAsync();
            return values.Select(t => new GetConfirmationReservationQueryResult
            {
                Date = t.Date,
                ReservationId = t.ReservationId,
                Email = t.Email,
                NameSurname =t.NameSurname,
                Phone = t.Phone,
                SpecialRequest = t.SpecialRequest,
                Status=t.Status,
            }).ToList();
        }
    }
}
