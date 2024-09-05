using CoffeBlend.Application.Features.Mediator.Results.GaleryResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Queries.GaleryQueries
{
    public class GetGaleryByIdQuery : IRequest<GetGaleryByIdQueryResult>
    {
        public int Id { get; set; }

        public GetGaleryByIdQuery(int id)
        {
            Id = id;
        }
    }
}
