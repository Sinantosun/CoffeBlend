using CoffeBlend.Application.Features.Mediator.Queries.AdminDashboardQueries;
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
    public class GetAdminDashboardTodayBalanceQueryHandler : IRequestHandler<GetAdminDashboardTodayBalanceQuery, GetAdminDashboardTodayBalanceQueryResult>
    {
        private readonly IDashboardRepository _repository;

        public GetAdminDashboardTodayBalanceQueryHandler(IDashboardRepository repository)
        {
            _repository = repository;
        }

        public Task<GetAdminDashboardTodayBalanceQueryResult> Handle(GetAdminDashboardTodayBalanceQuery request, CancellationToken cancellationToken)
        {
            return _repository.GetAdminDashboardTodayBalanceAsync();
        }
    }
}
