using CoffeBlend.Application.Features.Mediator.Results.ContactInfoResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Queries.ContactInfoQueries
{
    public class GetContactInfoByIdQuery : IRequest<GetContactInfoByIdQueryResult>
    {
        public int Id { get; set; }

        public GetContactInfoByIdQuery(int id)
        {
            Id = id;
        }
    }
}
