using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.ReservationCommands
{
    public class CancelReservationCommand : IRequest
    {
        public int Id { get; set; }

        public CancelReservationCommand(int id)
        {
            Id = id;
        }
    }
}
