using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.TestimonialCommands
{
    public class CreateTestimonailCommand : IRequest
    {
        public string Comment { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
    }
}
