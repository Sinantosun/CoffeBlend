using CoffeBlend.Application.Features.Mediator.Commands.PricingCommands;
using CoffeBlend.Application.Features.Mediator.Queries.PricingQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PricingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetPricingListAsync()
        {
            var values = await _mediator.Send(new GetPricingQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPricingByIdAsync(int id)
        {
            var value = await _mediator.Send(new GetPricingByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePricingAsync(CreatePricingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kayıt Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemovePricingAsync(int id)
        {
            await _mediator.Send(new RemovePricingCommand(id));
            return Ok("Kayıt Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePricingAsync(UpdatePricingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kayıt Güncellendi");
        }
    }
}
