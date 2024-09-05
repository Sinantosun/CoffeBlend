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
    public class UpdateMenuCommandHandler : IRequestHandler<UpdateMenuCommand>
    {
        private readonly IRepository<Menu> _repository;

        public UpdateMenuCommandHandler(IRepository<Menu> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateMenuCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.MenuId);
            value.Description = request.Description;    
            value.Title = request.Title;
            value.Image1 = request.Image1; 
            value.Image2 = request.Image2; 
            value.Image3 = request.Image3; 
            value.Image4 = request.Image4; 
            value.ShortTitle = request.ShortTitle; 
            await _repository.UpdateAsync(value);
        }
    }
}
