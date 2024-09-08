using CoffeBlend.Application.Features.Mediator.Commands.TableCommands;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.TableHandlers
{
    public class UpdateTableCommandHandler : IRequestHandler<UpdateTableCommand>
    {
        private readonly IRepository<Table> _repository;

        public UpdateTableCommandHandler(IRepository<Table> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTableCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.TableID);
            value.Name = request.Name;  
            value.Status= request.Status;
            value.Capacity= request.Capacity;   
            await _repository.UpdateAsync(value);   
        }
    }
}
