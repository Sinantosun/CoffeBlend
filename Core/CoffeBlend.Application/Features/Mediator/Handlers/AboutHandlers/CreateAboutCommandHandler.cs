using CoffeBlend.Application.Features.Mediator.Commands.AboutCommands;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.AboutHandlers
{
    public class CreateAboutCommandHandler : IRequestHandler<CreateAboutCommand>
    {
        private readonly IRepository<About> _repository;

        public CreateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAboutCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new About
            {
                Title = request.Title,
                Description = request.Description,
                ShortTitle = request.ShortTitle,
            });
        }
    }
}
