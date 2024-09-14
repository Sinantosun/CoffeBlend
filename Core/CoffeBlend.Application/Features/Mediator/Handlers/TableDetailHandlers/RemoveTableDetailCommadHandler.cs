using CoffeBlend.Application.Features.Mediator.Commands.TableDetailCommands;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.TableDetailHandlers
{
    public class RemoveTableDetailCommadHandler : IRequestHandler<RemoveTableDetailCommand>
    {
        private readonly IRepository<TableDetail> _repository;

        public RemoveTableDetailCommadHandler(IRepository<TableDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveTableDetailCommand request, CancellationToken cancellationToken)
        {
            await _repository.RemoveAsync(request.Id);
        }
    }
}
