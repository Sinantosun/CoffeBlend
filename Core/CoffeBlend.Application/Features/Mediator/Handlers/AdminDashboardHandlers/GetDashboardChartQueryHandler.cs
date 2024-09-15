using CoffeBlend.Application.Features.Mediator.Queries.GetDashboardChartQueries;
using CoffeBlend.Application.Features.Mediator.Results.AdminDashboardResults;
using CoffeBlend.Application.Interfaces.DashboardRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.AdminDashboardHandlers
{
    public class GetDashboardChartQueryHandler : IRequestHandler<GetDashboardChartQuery, GetDashboardChartQueryResult>
    {
        private readonly IDashboardRepository _dashboardRepository;

        public GetDashboardChartQueryHandler(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository;
        }

        public async Task<GetDashboardChartQueryResult> Handle(GetDashboardChartQuery request, CancellationToken cancellationToken)
        {
            return await _dashboardRepository.GetDashboardChartAsync();
        }
    }
}
