using CoffeBlend.Application.Features.Mediator.Commands.ReservationCommands;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Application.Interfaces.ReservationRepositories;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.ReservationHandlers
{
    public class RemoveReservationCommandHandler : IRequestHandler<RemoveReservationCommand>
    {
        private readonly IReservationRepository _reservationRepository;
        public RemoveReservationCommandHandler(IReservationRepository reservationRepository)
        {
         
            _reservationRepository = reservationRepository;
        }

        public async Task Handle(RemoveReservationCommand request, CancellationToken cancellationToken)
        {
            await _reservationRepository.RemoveAsync(request.Id);
        }
    }
}
