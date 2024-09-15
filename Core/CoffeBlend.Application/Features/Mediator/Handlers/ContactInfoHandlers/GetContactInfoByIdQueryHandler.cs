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
    public class GetContactInfoByIdQueryHandler : IRequestHandler<GetContactInfoByIdQuery, GetContactInfoByIdQueryResult>
    {
        private readonly IRepository<ContactInfo> _repository;

        public GetContactInfoByIdQueryHandler(IRepository<ContactInfo> repository)
        {
            _repository = repository;
        }

        public async Task<GetContactInfoByIdQueryResult> Handle(GetContactInfoByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetContactInfoByIdQueryResult
            {
                ContactInfoId = value.ContactInfoId,

                Description1 = value.Description1,
                Description2 = value.Description2,
                Description3 = value.Description3,

                Icon1 = value.Icon1,
                Icon2 = value.Icon2,
                Icon3 = value.Icon3,

                Title1 = value.Title1,
                Title2 = value.Title2,
                Title3 = value.Title3,
            };
        }
    }
}
