using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.GaleryCommands
{
    public class RemoveGaleryCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveGaleryCommand(int id)
        {
            Id = id;
        }
    }
}
