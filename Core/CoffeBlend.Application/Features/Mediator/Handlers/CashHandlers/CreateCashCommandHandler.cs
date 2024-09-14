using CoffeBlend.Application.Features.Mediator.Commands.CashCommands;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.CashHandlers
{
    public class CreateCashCommandHandler : IRequestHandler<CreateCashCommand>
    {
        private readonly IRepository<Cash> _repository;

        public CreateCashCommandHandler(IRepository<Cash> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCashCommand request, CancellationToken cancellationToken)
        {
           throw new NotImplementedException();
        }
    }
}
