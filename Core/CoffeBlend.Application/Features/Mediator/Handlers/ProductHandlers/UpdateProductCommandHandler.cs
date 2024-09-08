using CoffeBlend.Application.Features.Mediator.Commands.ProductCommands;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IRepository<Product> _repository;

        public UpdateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ProductId);
            value.ShortDescription = request.ShortDescription;
            value.ImageURL = request.ImageURL;
            value.Description = request.Description;
            value.Price = request.Price;    
            value.CategoryId = request.CategoryId;  
            value.Title = request.Title;
            await _repository.UpdateAsync(value);   
        }
    }
}
