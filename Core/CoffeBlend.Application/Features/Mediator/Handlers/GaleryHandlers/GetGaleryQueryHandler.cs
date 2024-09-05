using CoffeBlend.Application.Features.Mediator.Queries.GaleryQueries;
using CoffeBlend.Application.Features.Mediator.Results.GaleryResults;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.GaleryHandlers
{
    public class GetGaleryQueryHandler : IRequestHandler<GetGaleryQuery, List<GetGaleryQueryResult>>
    {
        private readonly IRepository<Galery> _repository;

        public GetGaleryQueryHandler(IRepository<Galery> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetGaleryQueryResult>> Handle(GetGaleryQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetListAsync();
            return values.Select(y => new GetGaleryQueryResult
            {
                GaleryId = y.GaleryId,
                ImageURL = y.ImageURL,
            }).ToList();

        }
    }
}
