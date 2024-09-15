using CoffeBlend.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Results.TableDetailResults
{
    public class GetTableOrderListByTableIdQueryResult
    {
        public int tableDetailID { get; set; }
        public int tableID { get; set; }
        public int productId { get; set; }
        public string productName { get; set; }
        public decimal quantity { get; set; }
        public decimal unitPrice { get; set; }
        public decimal totalPrice { get; set; }
    }
}
