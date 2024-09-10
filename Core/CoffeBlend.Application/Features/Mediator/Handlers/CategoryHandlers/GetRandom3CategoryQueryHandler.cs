using CoffeBlend.Application.Features.Mediator.Queries.CategoryQueries;
using CoffeBlend.Application.Features.Mediator.Results.CategoryResults;
using CoffeBlend.Application.Interfaces.CategoryRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.CategoryHandlers
{

    public class GetRandom3CategoryQueryHandler : IRequestHandler<GetRandom3CategoryQuery, List<GetRandom3CategoryQueryResult>>
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetRandom3CategoryQueryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<List<GetRandom3CategoryQueryResult>> Handle(GetRandom3CategoryQuery request, CancellationToken cancellationToken)
        {
            var values = await _categoryRepository.GetRandom3CategoryAsync();
            return values.Select(t => new GetRandom3CategoryQueryResult
            {
                CategoryId = t.CategoryId,
                Name=t.Name,

            }).ToList();
        }
    }
}
