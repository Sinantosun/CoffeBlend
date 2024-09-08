using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.TableCommands
{
    public class RemoveTableCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveTableCommand(int id)
        {
            Id = id;
        }
    }
}
