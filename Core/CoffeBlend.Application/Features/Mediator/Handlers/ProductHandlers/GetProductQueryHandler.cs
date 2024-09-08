using CoffeBlend.Application.Features.Mediator.Queries.ProductQueries;
using CoffeBlend.Application.Features.Mediator.Results.ProductResults;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.ProductHandlers
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, List<GetProductQueryResult>>
    {
        private readonly IRepository<Product> _repository;

        public GetProductQueryHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetProductQueryResult>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetListAsync();
            return values.Select(t => new GetProductQueryResult
            {
                ImageURL = t.ImageURL,  
                CategoryId = t.CategoryId,
                ProductId = t.ProductId,
                Description = t.Description,
                Price = t.Price,
                ShortDescription = t.ShortDescription,
                Title = t.Title,

            }).ToList();
        }
    }
}
