using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.DtoLayer.ProductPricingDtos
{
    public class CreateProductPricingDto
    {
        public int ProductId { get; set; }
        public int PricingId { get; set; }
        public decimal Amount { get; set; }
    }
}
