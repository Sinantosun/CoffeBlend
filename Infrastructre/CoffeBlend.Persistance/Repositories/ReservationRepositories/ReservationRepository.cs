using CoffeBlend.Application.Interfaces.ReservationRepositories;
using CoffeBlend.Domain.Entites;
using CoffeBlend.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Persistance.Repositories.ReservationRepositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly CoffeBlendContext _context;

        public ReservationRepository(CoffeBlendContext context)
        {
            _context = context;
        }

        public async Task ApproveReservationAsync(int reservationId)
        {
            var value = await _context.Reservations.FirstOrDefaultAsync(t => t.ReservationId == reservationId);
            value.Status = "Onaylandı";
            await _context.SaveChangesAsync();
        }

        public async Task CancelReservationAsync(int reservationId)
        {
            var value = await _context.Reservations.FirstOrDefaultAsync(t => t.ReservationId == reservationId);
            value.Status = "İptal Edildi";
            await _context.SaveChangesAsync();
        }

        public async Task<List<Reservation>> GetApprovedReservationAsync()
        {
            var value = await _context.Reservations.Where(t => t.Status == "Onaylandı").ToListAsync();
            return value;
        }

        public async Task<List<Reservation>> GetCanceledReservationAsync()
        {
            var value = await _context.Reservations.Where(t => t.Status == "İptal Edildi").ToListAsync();
            return value;
        }

        public async Task<List<Reservation>> GetConfirmationReseravtionAsync()
        {
            var value = await _context.Reservations.Where(t => t.Status == "Rezervasyon Alındı, Onay Bekliyor").ToListAsync();
            return value;
        }

       


    }
}
