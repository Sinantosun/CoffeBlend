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

        public async Task<GetAdminDashboardTodayBalanceQueryResult> GetAdminDashboardTodayBalance()
        {
            var value = await _context.Cashes.FirstOrDefaultAsync(t => t.Date == DateTime.Now.Date);
            return new GetAdminDashboardTodayBalanceQueryResult
            {
                
                Balance = value.Balance
            };

        }
    }
}
