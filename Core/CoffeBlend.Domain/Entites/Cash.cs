using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Domain.Entites
{
    public class Cash
    {
        public int CashID { get; set; }
        [Column(TypeName = "timestamp without time zone")]
        public DateTime Date { get; set; }
        public decimal Balance { get; set; }
    }
}
