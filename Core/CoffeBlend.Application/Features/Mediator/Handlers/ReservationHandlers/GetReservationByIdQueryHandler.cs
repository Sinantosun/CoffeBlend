using CoffeBlend.Application.Features.Mediator.Queries.ReservationQueries;
using CoffeBlend.Application.Features.Mediator.Results.ReservationResults;
using CoffeBlend.Application.Interfaces.GenericRepository;
using CoffeBlend.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Features.Mediator.Handlers.ReservationHandlers
{
    public class GetReservationByIdQueryHandler : IRequestHandler<GetReservationByIdQuery, GetReservationByIdQueryResult>
    {
        private readonly IRepository<Reservation> _repository;

        public GetReservationByIdQueryHandler(IRepository<Reservation> repository)
        {
            _repository = repository;
        }

        public async Task<GetReservationByIdQueryResult> Handle(GetReservationByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetReservationByIdQueryResult
            {
                TableID = value.TableID,
                Date = value.Date,
                Email = value.Email,
                NameSurname = value.NameSurname,
                Phone = value.Phone,
                ReservationId = value.ReservationId,
                SpecialRequest = value.SpecialRequest,
                Status = value.Status   
                
            };
        }
    }
}
