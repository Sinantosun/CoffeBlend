using CoffeBlend.Application.Features.Mediator.Commands.ProductPricingCommands;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.ProductPricingHandlers
{
    public class RemoveProductPricingCommandHandler : IRequestHandler<RemoveProductPricingCommand>
    {
        private readonly IRepository<ProductPricing> _repository;

        public RemoveProductPricingCommandHandler(IRepository<ProductPricing> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveProductPricingCommand request, CancellationToken cancellationToken)
        {
            await _repository.RemoveAsync(request.Id);
        }
    }
}
