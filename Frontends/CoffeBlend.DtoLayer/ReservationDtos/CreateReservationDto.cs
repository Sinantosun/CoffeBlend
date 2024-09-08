using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.DtoLayer.ReservationDtos
{
    public class CreateReservationDto
    {
        public int ReservationId { get; set; }
        public string NameSurname { get; set; }

        public DateTime Date { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string? SpecialRequest { get; set; }
        public string Status { get; set; }

        public int TableID { get; set; }
    
    }
}
