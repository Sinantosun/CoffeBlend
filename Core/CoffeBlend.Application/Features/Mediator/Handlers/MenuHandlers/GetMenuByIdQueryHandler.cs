using CoffeBlend.Application.Features.Mediator.Queries.MenuQueries;
using CoffeBlend.Application.Features.Mediator.Results.MenuResults;
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
    public class GetMenuByIdQueryHandler : IRequestHandler<GetMenuByIdQuery, GetMenuByIdQueryResult>
    {
        private readonly IRepository<Menu> _repository;

        public GetMenuByIdQueryHandler(IRepository<Menu> repository)
        {
            _repository = repository;
        }

        public async Task<GetMenuByIdQueryResult> Handle(GetMenuByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetMenuByIdQueryResult
            {
                Description = value.Description,
                Image1 = value.Image1,
                Image2 = value.Image2,
                Image3 = value.Image3,
                Image4 = value.Image4,
                MenuId = value.MenuId,
                ShortTitle = value.ShortTitle,
                Title = value.Title,


            };
        }
    }
}
