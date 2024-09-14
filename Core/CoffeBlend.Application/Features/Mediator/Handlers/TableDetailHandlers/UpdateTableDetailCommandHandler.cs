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
    public class UpdateTableDetailCommandHandler : IRequestHandler<UpdateTableDetailCommand>
    {
        private readonly IRepository<TableDetail> _repository;

        public UpdateTableDetailCommandHandler(IRepository<TableDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTableDetailCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.TableID);
            value.UnitPrice = request.UnitPrice;
            value.Quantity = request.Quantity;
            value.ProductId = request.ProductId;
            value.TableID = request.TableID;
            await _repository.UpdateAsync(value);
        }
    }
}
