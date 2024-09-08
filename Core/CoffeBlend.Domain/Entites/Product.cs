using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Domain.Entites
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<TableDetail> TableDetails { get; set; }
        public List<ProductPricing> ProductPricings { get; set; }

    }
}
