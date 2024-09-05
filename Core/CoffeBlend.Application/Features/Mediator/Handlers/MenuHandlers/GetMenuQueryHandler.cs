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
    public class GetMenuQueryHandler : IRequestHandler<GetMenuQuery, List<GetMenuQueryResult>>
    {
        private readonly IRepository<Menu> _repository;

        public GetMenuQueryHandler(IRepository<Menu> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetMenuQueryResult>> Handle(GetMenuQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetListAsync();
            return values.Select(t => new GetMenuQueryResult
            {
                Description = t.Description,
                Image1 = t.Image1,
                Image2 = t.Image2,
                Image3 = t.Image3,
                Image4 = t.Image4,
                MenuId = t.MenuId,
                ShortTitle = t.ShortTitle,
                Title = t.Title
            }).ToList();
        }
    }
}
