using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.DtoLayer.AdminDashboardDtos
{
    public class ResultAdminWidgetStatisticDto
    {
        public int ActiveTableCount { get; set; }
        public int ProductCount { get; set; }
        public int CategoryCount { get; set; }
        public int ActiveReservationCount { get; set; }
    }
}
