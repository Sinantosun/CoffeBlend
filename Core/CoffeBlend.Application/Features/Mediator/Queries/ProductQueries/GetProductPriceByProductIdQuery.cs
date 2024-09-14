using CoffeBlend.Application.Features.Mediator.Results.ProductResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Queries.ProductQueries
{
    public class GetProductPriceByProductIdQuery : IRequest<GetProductPriceByProductIdQueryResult>
    {
        public int Id { get; set; }

        public GetProductPriceByProductIdQuery(int id)
        {
            Id = id;
        }
    }
}
