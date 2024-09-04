﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Commands.AboutCommands
{
    public class UpdateAboutCommand : IRequest
    {
        public int AboutId { get; set; }
        public string ShortTitle { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
