using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.TestimonialCommands
{
    public class RemoveTestimonailCommand :  IRequest
    {
        public int Id { get; set; }

        public RemoveTestimonailCommand(int id)
        {
            Id = id;
        }
    }
}
