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
    public class CreateTableCommandHandler : IRequestHandler<CreateTableCommand>
    {
        private readonly IRepository<Table> _repository;

        public CreateTableCommandHandler(IRepository<Table> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateTableCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Table
            {
                Name = request.Name,
                Status = true,
                Capacity = request.Capacity,
            });

        }
    }
}
