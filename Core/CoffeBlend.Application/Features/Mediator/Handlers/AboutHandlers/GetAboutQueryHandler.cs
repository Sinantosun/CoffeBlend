using CoffeBlend.Application.Features.Mediator.Queries.AboutQueries;
using CoffeBlend.Application.Features.Mediator.Results.AboutResults;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler : IRequestHandler<GetAboutQuery, List<GetAboutQueryResult>>
    {
        private readonly IRepository<About> _repository;

        public GetAboutQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAboutQueryResult>> Handle(GetAboutQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetListAsync();
            return values.Select(t => new GetAboutQueryResult
            {
                AboutId = t.AboutId,
                Description = t.Description,
                ShortTitle = t.ShortTitle,
                Title = t.Title,
            }).ToList();
        }
    }
}
