using CoffeBlend.Application.Features.Mediator.Queries.ContactInfoQueries;
using CoffeBlend.Application.Features.Mediator.Results.ContactInfoResults;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.ContactInfoHandlers
{
    public class GetContactInfoQueryHandler : IRequestHandler<GetContactInfoQuery, List<GetContactInfoQueryResult>>
    {
        private readonly IRepository<ContactInfo> _repository;

        public GetContactInfoQueryHandler(IRepository<ContactInfo> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetContactInfoQueryResult>> Handle(GetContactInfoQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetListAsync();
            return value.Select(y => new GetContactInfoQueryResult
            {
                ContactInfoId = y.ContactInfoId,

                Description1 = y.Description1,
                Description2 = y.Description2,
                Description3 = y.Description3,

                Icon1 = y.Icon1,
                Icon2 = y.Icon2,
                Icon3 = y.Icon3,

                Title1 = y.Title1,
                Title2 = y.Title2,
                Title3 = y.Title3,
            }).ToList();
        }
    }
}
