using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.TableDetailCommands
{
    public class RemoveTableDetailCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveTableDetailCommand(int id)
        {
            Id = id;
        }
    }
}
