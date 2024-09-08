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
    public class UpdatePoductPricingCommandHandler : IRequestHandler<UpdateProductPricingCommand>
    {
        private readonly IRepository<ProductPricing> _repository;

        public UpdatePoductPricingCommandHandler(IRepository<ProductPricing> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateProductPricingCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ProductPricingId);
            values.Amount = request.Amount;
            values.ProductId = request.ProductId;
            values.PricingId = request.PricingId;
            await _repository.UpdateAsync(values);
        }
    }
}
