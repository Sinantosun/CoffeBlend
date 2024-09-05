using CoffeBlend.Application.Features.Mediator.Results.StatisticResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Queries.StatisticQueries
{ 
    public class GetStatisticByIdQuery : IRequest<GetStatisticByIdQueryResult>
    {
        public int Id { get; set; }

        public GetStatisticByIdQuery(int id)
        {
            Id = id;
        }
    }
}
