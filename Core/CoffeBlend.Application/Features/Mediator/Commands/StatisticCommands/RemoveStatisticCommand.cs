using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.StatisticCommands
{
    public class RemoveStatisticCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveStatisticCommand(int id)
        {
            Id = id;
        }
    }
}
