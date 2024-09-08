﻿using CoffeBlend.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Interfaces.ReservationRepositories
{
    public interface IReservationRepository
    {
        Task ApproveReservationAsync(int reservationId);
        Task CancelReservationAsync(int reservationId);

        Task<List<Reservation>> GetApprovedReservationAsync();
        Task<List<Reservation>> GetCanceledReservationAsync();
        Task<List<Reservation>> GetConfirmationReseravtionAsync();
   
    }
}