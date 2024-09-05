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
                Description = y.Description,
                Icon = y.Icon,
                Title = y.Title,
            }).ToList();
        }
    }
}
