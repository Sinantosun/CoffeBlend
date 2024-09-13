﻿using CoffeBlend.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Results.TableResults
{
    public class GetTableQueryResult
    {
        public int TableID { get; set; }
        public string Name { get; set; }
        public byte Status { get; set; }
        public int Capacity { get; set; }


    }
}
