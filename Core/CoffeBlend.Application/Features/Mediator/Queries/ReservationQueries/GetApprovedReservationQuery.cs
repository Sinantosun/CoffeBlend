using CoffeBlend.Application.Features.Mediator.Results.ReservationResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Queries.ReservationQueries
{
    public class GetApprovedReservationQuery : IRequest<List<GetApprovedReservationQueryResult>>
    {
    }
}
