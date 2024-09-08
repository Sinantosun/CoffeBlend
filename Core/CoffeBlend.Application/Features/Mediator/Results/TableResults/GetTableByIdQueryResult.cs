using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Results.TableResults
{
    public class GetTableByIdQueryResult
    {
        public int TableID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
