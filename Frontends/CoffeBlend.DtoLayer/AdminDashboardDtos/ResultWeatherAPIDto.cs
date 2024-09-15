using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.DtoLayer.AdminDashboardDtos
{
    public class ResultWeatherAPIDto
    {
        public Current current { get; set; }

        public class Current
        {
            public string last_updated { get; set; }
            public float temp_c { get; set; }
            public int is_day { get; set; }
            public Condition condition { get; set; }

        }

        public class Condition
        {
            public string text { get; set; }
            public string icon { get; set; }
            public int code { get; set; }
        }

    }
}
