using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.DtoLayer.ProductPricingDtos
{
    public class ResultProductPricingByIdDto
    {
        public int ProductPricingId { get; set; }
        public int ProductId { get; set; }
        public int PricingId { get; set; }
        public decimal Amount { get; set; }
    }
}
