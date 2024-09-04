using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Domain.Entites
{
    public class Statistic
    {
        public int StatisticId { get; set; }
        public string Icon  { get; set; }
        public string Amount  { get; set; }
        public string Title  { get; set; }
    }
}
