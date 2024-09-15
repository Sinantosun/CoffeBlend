using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.ContactInfoCommands
{
    public class CreateContactInfoCommand : IRequest
    {
      
        public string Icon1 { get; set; }
        public string Title1 { get; set; }
        public string Description1 { get; set; }

        public string Icon2 { get; set; }
        public string Title2 { get; set; }
        public string Description2 { get; set; }

        public string Icon3 { get; set; }
        public string Title3 { get; set; }
        public string Description3 { get; set; }
    }
}
