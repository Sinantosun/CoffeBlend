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
    public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand>
    {
        private readonly IReservationRepository _repository;

        public CreateReservationCommandHandler(IReservationRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateReservationAsync(request);
        }
    }
}
