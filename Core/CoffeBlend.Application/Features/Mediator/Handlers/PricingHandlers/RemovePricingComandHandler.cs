using CoffeBlend.Application.Features.Mediator.Commands.PricingCommands;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.PricingHandlers
{
    public class RemovePricingComandHandler : IRequestHandler<RemovePricingCommand>
    {
        private readonly IRepository<Pricing> _repository;

        public RemovePricingComandHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemovePricingCommand request, CancellationToken cancellationToken)
        {
            await _repository.RemoveAsync(request.Id);
        }
    }
}
