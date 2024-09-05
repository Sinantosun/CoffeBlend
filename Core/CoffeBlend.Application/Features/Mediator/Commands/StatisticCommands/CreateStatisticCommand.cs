using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.StatisticCommands
{
    public class CreateStatisticCommand : IRequest
    {

        public string Icon { get; set; }
        public int Amount { get; set; }
        public string Title { get; set; }
    }
}
