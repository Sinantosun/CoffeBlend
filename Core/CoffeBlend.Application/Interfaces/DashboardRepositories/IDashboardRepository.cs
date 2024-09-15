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
        public Task<GetAdminDashboardTodayBalanceQueryResult> GetAdminDashboardTodayBalanceAsync();
        public Task<GetDashboardChartQueryResult> GetDashboardChartAsync();
        public Task<GetAdminWidgetStatisticQueryResult> GetAdminWidgetStatisticAsync();

       
        // Active Table Count
        // Menu Count
        //Category Count
        //Reservation Count


    }
}
