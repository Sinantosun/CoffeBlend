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
    public class CreateProductPricingCommandHandler : IRequestHandler<CreateProductPricingCommand>
    {
        private readonly IRepository<ProductPricing> _repository;

        public CreateProductPricingCommandHandler(IRepository<ProductPricing> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateProductPricingCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new ProductPricing
            {
                Amount = request.Amount,
                ProductId = request.ProductId,
                PricingId = request.PricingId,

            });
        }
    }
}
