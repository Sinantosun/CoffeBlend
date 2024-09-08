using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.ReservationCommands
{
    public class ApproveReseravtionCommand : IRequest
    {
        public int Id { get; set; }

        public ApproveReseravtionCommand(int id)
        {
            Id = id;
        }
    }
}
