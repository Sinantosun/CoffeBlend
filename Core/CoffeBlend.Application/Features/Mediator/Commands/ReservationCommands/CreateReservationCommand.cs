﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.ReservationCommands
{
    public class CreateReservationCommand : IRequest
    {
        public string NameSurname { get; set; }
        public DateTime Date { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string? SpecialRequest { get; set; }
        public string Status { get; set; }
    }
}