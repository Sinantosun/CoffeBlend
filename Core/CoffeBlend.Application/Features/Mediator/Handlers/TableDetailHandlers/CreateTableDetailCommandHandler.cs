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
    public class CreateTableDetailCommandHandler : IRequestHandler<CreateTableDetailCommand>
    {
        private readonly IRepository<TableDetail> _repository;

        public CreateTableDetailCommandHandler(IRepository<TableDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateTableDetailCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new TableDetail
            {
                TotalPrice=request.UnitPrice * request.Quantity,
                TableID = request.TableID,
                ProductId = request.ProductId,
                Quantity = request.Quantity,
                UnitPrice = request.UnitPrice,
            });
        }
    }
}
