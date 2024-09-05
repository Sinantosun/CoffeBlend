﻿using CoffeBlend.Application.Features.Mediator.Results.MenuResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Queries.MenuQueries
{
    public class GetMenuQuery : IRequest<List<GetMenuQueryResult>>
    {
    }
}
