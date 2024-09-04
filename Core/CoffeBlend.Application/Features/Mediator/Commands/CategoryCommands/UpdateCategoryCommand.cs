using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.CategoryCommands
{
    public class UpdateCategoryCommand : IRequest
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
