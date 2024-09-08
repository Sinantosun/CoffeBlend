using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Domain.Entites
{
    public class TableDetail
    {
        public int TableDetailID { get; set; }
        public int TableID { get; set; }
        public Table Table { get; set; }
      
        public int ProductId { get; set; }
        public Product product { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get => Quantity * UnitPrice; }
    }
}
