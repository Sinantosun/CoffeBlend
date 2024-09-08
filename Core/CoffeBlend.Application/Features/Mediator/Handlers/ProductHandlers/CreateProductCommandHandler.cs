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
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly IRepository<Product> _repository;

        public CreateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Product
            {
                ImageURL = request.ImageURL,
                CategoryId = request.CategoryId,
                Description = request.Description,
                Price = request.Price,
                ShortDescription = request.ShortDescription,
                Title = request.Title,

            });
        }
    }
}
