using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.DtoLayer.ProductDtos
{
    internal class ResultLast5Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
