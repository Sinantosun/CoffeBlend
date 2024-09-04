using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.AboutCommands
{
    public class CreateAboutCommand : IRequest
    {
        public string ShortTitle { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
