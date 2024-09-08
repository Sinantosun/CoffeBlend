﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.ProductPricingCommands
{
    public class RemoveProductPricingCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveProductPricingCommand(int id)
        {
            Id = id;
        }
    }
}