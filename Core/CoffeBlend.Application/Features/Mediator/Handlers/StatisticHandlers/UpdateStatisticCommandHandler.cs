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
    public class UpdateStatisticCommandHandler : IRequestHandler<UpdateStatisticCommand>
    {
        private readonly IRepository<Statistic> _repository;

        public UpdateStatisticCommandHandler(IRepository<Statistic> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateStatisticCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.StatisticId);
            value.Title = request.Title;
            value.Amount = request.Amount;
            value.Icon = request.Icon;
            await _repository.UpdateAsync(value);
        }
    }
}
