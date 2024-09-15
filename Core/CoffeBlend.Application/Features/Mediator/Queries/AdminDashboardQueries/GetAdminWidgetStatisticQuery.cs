using CoffeBlend.Application.Features.Mediator.Results.AdminDashboardResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Queries.AdminDashboardQueries
{
    public class GetAdminWidgetStatisticQuery : IRequest<GetAdminWidgetStatisticQueryResult>
    {
    }
}
