using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Domain.Entites
{
    public class Table
    {
        public int TableID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public int Capacity { get; set; }

        public List<Reservation> Reservations  { get; set; }



    }
}
