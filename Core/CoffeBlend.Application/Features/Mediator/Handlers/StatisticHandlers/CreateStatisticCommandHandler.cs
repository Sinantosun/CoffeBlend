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
    public class CreateStatisticCommandHandler : IRequestHandler<CreateStatisticCommand>
    {
        private readonly IRepository<Statistic> _repository;

        public CreateStatisticCommandHandler(IRepository<Statistic> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateStatisticCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Statistic
            {
                Amount = request.Amount,
                Icon = request.Icon,
                Title = request.Title,
            });
        }
    }
}
