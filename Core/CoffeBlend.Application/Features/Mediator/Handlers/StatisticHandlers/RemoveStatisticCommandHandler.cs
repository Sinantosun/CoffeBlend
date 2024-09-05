using CoffeBlend.Application.Features.Mediator.Commands.StatisticCommands;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.StatisticHandlers
{
    public class RemoveStatisticCommandHandler : IRequestHandler<RemoveStatisticCommand>
    {
        private readonly IRepository<Statistic> _repository;

        public RemoveStatisticCommandHandler(IRepository<Statistic> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveStatisticCommand request, CancellationToken cancellationToken)
        {
            await _repository.RemoveAsync(request.Id);
        }
    }
}
