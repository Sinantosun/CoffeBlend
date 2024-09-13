using CoffeBlend.Application.Enums;
using CoffeBlend.Application.Interfaces.TableRepositories;
using CoffeBlend.Domain.Entites;
using CoffeBlend.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Persistance.Repositories.TableRepositories
{
    public class TableRepository : ITableRepository
    {
        private readonly CoffeBlendContext _context;

        public TableRepository(CoffeBlendContext context)
        {
            _context = context;
        }

        public async Task<List<Table>> GetActiveTableList()
        {
            var values = await _context.Tables.Where(t => t.Status ==(byte)TableStatusTypes.Active).ToListAsync();
            return values;
        }

        public async Task<List<Table>> GetDeactiveTableList()
        {
            var values = await _context.Tables.Where(t => t.Status == (byte)TableStatusTypes.Deactive).ToListAsync();
            return values;
        }
    }
}
