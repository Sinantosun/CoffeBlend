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
                Description = request.Description,
                Icon = request.Icon,
                Title = request.Title,
            });
        }
    }
}
