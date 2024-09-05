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
            value.Description = request.Description;    
            value.Icon = request.Icon;
            value.Title = request.Title;
            await _repository.UpdateAsync(value);   
        }
    }
}
