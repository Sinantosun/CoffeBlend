using CoffeBlend.Application.Features.Mediator.Commands.ContactInfoCommands;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.ContactInfoHandlers
{
    public class CreateContactInfoCommandHandler : IRequestHandler<CreateContactInfoCommand>
    {
        private readonly IRepository<ContactInfo> _repository;

        public CreateContactInfoCommandHandler(IRepository<ContactInfo> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateContactInfoCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new ContactInfo
            {
                Description1 = request.Description1,
                Description2 = request.Description2,
                Description3 = request.Description3,

                Icon1 = request.Icon1,
                Icon2 = request.Icon2,
                Icon3 = request.Icon3,

                Title1 = request.Title1,
                Title2 = request.Title2,
                Title3 = request.Title3,

            });
        }
    }
}
