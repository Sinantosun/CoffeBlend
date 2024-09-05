using CoffeBlend.Application.Features.Mediator.Commands.CategoryCommands;
using CoffeBlend.Application.Features.Mediator.Commands.GaleryCommands;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.GaleryHandlers
{
    public class RemoveGaleryCommandHandler : IRequestHandler<RemoveGaleryCommand>
    {
        private readonly IRepository<Galery> _repository;

        public RemoveGaleryCommandHandler(IRepository<Galery> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveGaleryCommand request, CancellationToken cancellationToken)
        {
            await _repository.RemoveAsync(request.Id);
        }
    }
}
