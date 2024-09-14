using CoffeBlend.Application.Features.Mediator.Results.AdminDashboardResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Interfaces.DashboardRepositories
{
    public interface IDashboardRepository 
    {
        public Task<GetAdminDashboardTodayBalanceQueryResult> GetAdminDashboardTodayBalance();
    }
}
