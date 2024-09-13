using CoffeBlend.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Interfaces.TableRepositories
{
    public interface ITableRepository
    {
        Task<List<Table>> GetActiveTableList();
        Task<List<Table>> GetDeactiveTableList();
    }
}
