using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Results.AdminDashboardResults
{
    public class GetAdminWidgetStatisticQueryResult
    {
        public int ActiveTableCount { get; set; }
        public int ProductCount { get; set; }
        public int CategoryCount { get; set; }
        public int ActiveReservationCount { get; set; }
        public int TodayReservationCount { get; set; }
        public int BusyTableCount { get; set; }

    }
}
