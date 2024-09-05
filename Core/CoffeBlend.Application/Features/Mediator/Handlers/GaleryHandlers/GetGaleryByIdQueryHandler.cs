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
    public class GetGaleryByIdQueryHandler : IRequestHandler<GetGaleryByIdQuery, GetGaleryByIdQueryResult>
    {
        private readonly IRepository<Galery> _repository;

        public GetGaleryByIdQueryHandler(IRepository<Galery> repository)
        {
            _repository = repository;
        }

        public async Task<GetGaleryByIdQueryResult> Handle(GetGaleryByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetGaleryByIdQueryResult
            {
                GaleryId = value.GaleryId,
                ImageURL = value.ImageURL,
            };
        }
    }
}
