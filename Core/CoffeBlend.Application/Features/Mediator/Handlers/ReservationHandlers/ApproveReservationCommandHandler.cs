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
    public class ApproveReservationCommandHandler : IRequestHandler<ApproveReseravtionCommand>
    {
        private readonly IReservationRepository _reservationrepository;

        public ApproveReservationCommandHandler(IReservationRepository reservationrepository)
        {
            _reservationrepository = reservationrepository;
        }

        public async Task Handle(ApproveReseravtionCommand request, CancellationToken cancellationToken)
        {
            await _reservationrepository.ApproveReservationAsync(request.Id);
        }
    }
}
