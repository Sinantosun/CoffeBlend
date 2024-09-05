using CoffeBlend.Application.Features.Mediator.Queries.TestimonialQueries;
using CoffeBlend.Application.Features.Mediator.Results.TestimonialResults;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetListAsync();
            return values.Select(t => new GetTestimonialQueryResult
            {
                Comment = t.Comment,
                NameSurname = t.NameSurname,
                TestimonialID = t.TestimonialID,
                Title = t.Title,
                
            }).ToList();
        }
    }
}
