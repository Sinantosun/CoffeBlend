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
    public class UpdateContactInfoCommandHandler : IRequestHandler<UpdateContactInfoCommand>
    {
        private readonly IRepository<ContactInfo> _repository;

        public UpdateContactInfoCommandHandler(IRepository<ContactInfo> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateContactInfoCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ContactInfoId);

            value.Description1 = request.Description1;
            value.Description2 = request.Description2;
            value.Description3 = request.Description3;

            value.Icon1 = request.Icon1;
            value.Icon2 = request.Icon2;
            value.Icon3 = request.Icon3;

            value.Title1 = request.Title1;
            value.Title2 = request.Title2;
            value.Title3 = request.Title3;
            await _repository.UpdateAsync(value);
        }
    }
}
