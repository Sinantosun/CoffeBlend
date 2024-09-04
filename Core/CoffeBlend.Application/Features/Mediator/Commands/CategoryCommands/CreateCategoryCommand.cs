using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.CategoryCommands
{
    public class CreateCategoryCommand : IRequest
    {
   
        public string Name { get; set; }
    }
}
