using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.DtoLayer.AdminDashboardDtos
{
    public class GetChartDto
    {
        public string NowDate { get; set; }
        public string OldDate { get; set; }

        public decimal NowDateAmount { get; set; }
        public decimal OldDateAmount { get; set; }
    }
}
