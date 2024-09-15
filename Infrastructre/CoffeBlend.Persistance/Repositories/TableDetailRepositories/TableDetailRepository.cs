using CoffeBlend.Application.Features.Mediator.Results.TableDetailResults;
using CoffeBlend.Application.Interfaces.TableDetailRepositories;
using CoffeBlend.Domain.Entites;
using CoffeBlend.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Persistance.Repositories.TableDetailRepositories
{
    public class TableDetailRepository : ITableDetailRepository
    {
        private readonly CoffeBlendContext _context;

        public TableDetailRepository(CoffeBlendContext context)
        {
            _context = context;
        }

        public async Task<List<GetTableOrderListByTableIdQueryResult>> GetTableOrderListByTableIdAsync(int id)
        {
            var values = await _context.tableDetails.Where(t => t.TableID == id).Include(y => y.product).ToListAsync();
            return values.Select(t => new GetTableOrderListByTableIdQueryResult
            {
                productId = t.ProductId,
                productName = t.product.Title,
                quantity = t.Quantity,
                tableDetailID = t.TableDetailID,
                tableID = t.TableID,
                totalPrice = t.TotalPrice,
                unitPrice = t.UnitPrice

            }).ToList();

        }
    }
}
