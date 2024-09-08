using CoffeBlend.Application.Features.Mediator.Results.ProductPricingResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Queries.ProductPricingQueries
{
    public class GetProductPricingQuery : IRequest<List<GetProductPricingQueryResult>>
    {
    }
}
