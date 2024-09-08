using CoffeBlend.Application.Features.Mediator.Commands.ReservationCommands;
using CoffeBlend.Application.Interfaces.ReservationRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.ReservationHandlers
{
    public class CancelReservationCommandHandler : IRequestHandler<CancelReservationCommand>
    {
        private readonly IReservationRepository _reservationRepository;

        public CancelReservationCommandHandler(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task Handle(CancelReservationCommand request, CancellationToken cancellationToken)
        {
            await _reservationRepository.CancelReservationAsync(request.Id);
        }
    }
}
