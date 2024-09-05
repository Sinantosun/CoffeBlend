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
    public class UpdateGaleryCommandHandler : IRequestHandler<UpdateGaleryCommand>
    {
        private readonly IRepository<Galery> _repository;

        public UpdateGaleryCommandHandler(IRepository<Galery> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateGaleryCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.GaleryId);
            value.ImageURL = request.ImageURL;
            await _repository.UpdateAsync(value);
            

        }
    }
}
