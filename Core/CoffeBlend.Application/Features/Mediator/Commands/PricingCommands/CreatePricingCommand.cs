using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.PricingCommands
{
    public class CreatePricingCommand : IRequest
    {
        public int PricingId { get; set; }
        public string Name { get; set; }
    }
}
