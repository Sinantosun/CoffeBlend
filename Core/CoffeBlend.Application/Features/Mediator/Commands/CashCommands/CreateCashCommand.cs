using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.CashCommands
{
    public class CreateCashCommand : IRequest
    {
        public decimal Balance { get; set; }
    }
}
