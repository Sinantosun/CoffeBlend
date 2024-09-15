using CoffeBlend.Application.Features.Mediator.Results.AdminDashboardResults;
using CoffeBlend.Application.Interfaces.DashboardRepositories;
using CoffeBlend.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Persistance.Repositories.DashboardRepositories
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly CoffeBlendContext _context;

        public DashboardRepository(CoffeBlendContext context)
        {
            _context = context;
        }

        public async Task<GetAdminDashboardTodayBalanceQueryResult> GetAdminDashboardTodayBalanceAsync()
        {
            var value = await _context.Cashes.FirstOrDefaultAsync(t => t.Date == DateTime.Now.Date);
            return new GetAdminDashboardTodayBalanceQueryResult
            {

                Balance = value.Balance
            };

        }

        public async Task<GetAdminWidgetStatisticQueryResult> GetAdminWidgetStatisticAsync()
        {
            return new GetAdminWidgetStatisticQueryResult
            {
                ActiveReservationCount = await _context.Reservations.Where(t => t.Status == "Onaylandı").CountAsync(),
                ActiveTableCount = await _context.Tables.Where(t => t.Status == 1).CountAsync(),
                CategoryCount = await _context.Categories.CountAsync(),
                ProductCount = await _context.Products.CountAsync(),
                TodayReservationCount = await _context.Reservations.Where(t => t.Date.Date == DateTime.Now.Date).CountAsync(),
                BusyTableCount = await _context.Tables.Where(t => t.Status == 3).CountAsync(),
            };
        }

        public async Task<GetDashboardChartQueryResult> GetDashboardChartAsync()
        {
            DateTime NowDate = DateTime.Now.Date;
            DateTime OldDate = DateTime.Now.Date.AddDays(-1);

            var NowDateAmount = await _context.Cashes.Where(t => t.Date == NowDate).Select(t => t.Balance).FirstOrDefaultAsync();
            var OldDateAmount = await _context.Cashes.Where(t => t.Date == OldDate).Select(t => t.Balance).FirstOrDefaultAsync();

            return new GetDashboardChartQueryResult
            {
                NowDate = NowDate.ToString("dd MMMM dddd"),
                OldDate = OldDate.ToString("dd MMMM dddd"),
                OldDateAmount = OldDateAmount,
                NowDateAmount = NowDateAmount,
            };
        }
    }
}
