using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.TableCommands
{
    public class CreateTableCommand : IRequest
    {
        public string Name { get; set; }
        public byte Status { get; set; }
        public int Capacity { get; set; }
    }
}
