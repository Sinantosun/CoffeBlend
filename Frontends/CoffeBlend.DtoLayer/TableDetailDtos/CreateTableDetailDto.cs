﻿using CoffeBlend.DtoLayer.ProductDtos;
using CoffeBlend.DtoLayer.TableDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.DtoLayer.TableDetailDtos
{
    public class CreateTableDetailDto
    {
        public int TableID { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
