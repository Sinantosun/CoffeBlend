using CoffeBlend.Application.Features.Mediator.Commands.MenuCommands;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.MenuHandlers
{
    public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommand>
    {
        private readonly IRepository<Menu> _repository;

        public CreateMenuCommandHandler(IRepository<Menu> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateMenuCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Menu
            {
                Description = request.Description,
                Image1 = request.Image1,
                Image2 = request.Image2,
                Image3 = request.Image3,
                Image4 = request.Image4,
                ShortTitle = request.ShortTitle,
                Title = request.Title,
            });
        }
    }
}
