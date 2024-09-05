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
    public class RemoveMenuCommandHandler : IRequestHandler<RemoveMenuCommand>
    {
        private readonly IRepository<Menu> _repository;

        public RemoveMenuCommandHandler(IRepository<Menu> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveMenuCommand request, CancellationToken cancellationToken)
        {
            await _repository.RemoveAsync(request.Id);
        }
    }
}
