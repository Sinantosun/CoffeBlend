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
                ContactInfoId= value.ContactInfoId,
                Description= value.Description,
                Icon = value.Icon,
                Title = value.Title 
            };
        }
    }
}
