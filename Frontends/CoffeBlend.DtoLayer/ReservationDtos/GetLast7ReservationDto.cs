﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.DtoLayer.ReservationDtos
{
    public class GetLast7ReservationDto
    {
        public int ReservationId { get; set; }
        public string NameSurname { get; set; }
        public DateTime Date { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }

        public string TableName { get; set; }
    }
}
