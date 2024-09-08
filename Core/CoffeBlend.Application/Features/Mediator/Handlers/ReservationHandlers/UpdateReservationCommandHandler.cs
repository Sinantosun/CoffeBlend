using CoffeBlend.Application.Features.Mediator.Commands.ReservationCommands;
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
    public class UpdateReservationCommandHandler : IRequestHandler<UpdateReservationCommand>
    {
        private readonly IRepository<Reservation> _repository;

        public UpdateReservationCommandHandler(IRepository<Reservation> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateReservationCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ReservationId);
            value.Status = request.Status;
            value.Email = request.Email;
            value.Date = request.Date;
            value.SpecialRequest = request.SpecialRequest;
            value.NameSurname = request.NameSurname;
            value.TableID = request.tableID;    
            await _repository.UpdateAsync(value);
        }
    }
}
