using CoffeBlend.Application.Features.Mediator.Results.CategoryResults;
using CoffeBlend.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Results.ProductResults
{
    public class GetProductQueryResult
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }

        public int CategoryId { get; set; }
    }
}
