﻿using CoffeBlend.Application.Features.Mediator.Results.TableDetailResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Queries.TableDetailQueries
{
    public class GetTableOrderListByTableIdQuery : IRequest<List<GetTableOrderListByTableIdQueryResult>>
    {
        public int Id { get; set; }

        public GetTableOrderListByTableIdQuery(int id)
        {
            Id = id;
        }
    }
}
