﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.CategoryCommands
{
    public class RemoveCategoryCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveCategoryCommand(int id)
        {
            Id = id;
        }
    }
}
