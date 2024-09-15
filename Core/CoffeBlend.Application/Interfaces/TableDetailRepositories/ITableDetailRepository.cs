using CoffeBlend.Application.Features.Mediator.Results.TableDetailResults;
using CoffeBlend.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Interfaces.TableDetailRepositories
{
    public interface ITableDetailRepository
    {
        Task<List<GetTableOrderListByTableIdQueryResult>> GetTableOrderListByTableIdAsync(int id);
    }
}
