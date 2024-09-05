using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.GaleryCommands
{
    public class UpdateGaleryCommand : IRequest
    {
        public int GaleryId { get; set; }
        public string ImageURL { get; set; }
    }
}
