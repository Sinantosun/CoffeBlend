using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.TableCommands
{
    public class UpdateTableCommand : IRequest
    {
        public int TableID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
