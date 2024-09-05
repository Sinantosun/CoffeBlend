using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.MenuCommands
{
    public class RemoveMenuCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveMenuCommand(int id)
        {
            Id = id;
        }
    }
}
