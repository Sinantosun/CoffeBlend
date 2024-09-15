using CoffeBlend.Application.Enums;
using CoffeBlend.Application.Features.Mediator.Commands.ReservationCommands;
using CoffeBlend.Application.Interfaces.ReservationRepositories;
using CoffeBlend.Domain.Entites;
using CoffeBlend.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
            var tableValue = await _context.Tables.FirstOrDefaultAsync(t => t.TableID == value.TableID);
            tableValue.Status = (byte)TableStatusTypes.Deactive;
            await _context.SaveChangesAsync();
        }

        public async Task CancelReservationAsync(int reservationId)
        {
            var value = await _context.Reservations.FirstOrDefaultAsync(t => t.ReservationId == reservationId);
            value.Status = "İptal Edildi";
            var tableValue = await _context.Tables.FirstOrDefaultAsync(t => t.TableID == value.TableID);
            tableValue.Status = (byte)TableStatusTypes.Active;
            await _context.SaveChangesAsync();
        }

        public async Task CreateReservationAsync(CreateReservationCommand command)
        {
            await _context.Reservations.AddAsync(new Reservation
            {
                Date = command.Date,
                Email = command.Email,
                NameSurname = command.NameSurname,
                Phone = command.Phone,
                SpecialRequest = command.SpecialRequest,
                TableID = command.tableID,
                Status = "Rezervasyon Alındı, Onay Bekliyor",

            });
            var tableValue = await _context.Tables.FirstOrDefaultAsync(t => t.TableID == command.tableID);
            tableValue.Status = (byte)TableStatusTypes.Reseravtion;
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

        public async Task<List<Reservation>> GetLast7ReservationAsync()
        {
            var values = await _context.Reservations.OrderByDescending(t => t.TableID).Take(7).Include(t=>t.Table).ToListAsync();
            return values;
        }

        public async Task RemoveAsync(int id)
        {
            var value = await _context.Reservations.FindAsync(id);
             _context.Reservations.Remove(value);

            var tableValue = await _context.Tables.FirstOrDefaultAsync(t => t.TableID == value.TableID);
            tableValue.Status = (byte)TableStatusTypes.Active;
            await _context.SaveChangesAsync();
        }
    }
}
