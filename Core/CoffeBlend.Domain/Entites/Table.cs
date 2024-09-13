using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Domain.Entites
{
    public class Table
    {
        public int TableID { get; set; }
        public string Name { get; set; }
      
        public byte Status { get; set; }
        public int Capacity { get; set; }

        public List<Reservation> Reservations  { get; set; }



    }
}
