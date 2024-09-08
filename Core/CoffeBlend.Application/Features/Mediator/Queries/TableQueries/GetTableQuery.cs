using CoffeBlend.Application.Features.Mediator.Results.TableResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Queries.TableQueries
{
    public class GetTableQuery : IRequest<List<GetTableQueryResult>>
    {
    }
}
