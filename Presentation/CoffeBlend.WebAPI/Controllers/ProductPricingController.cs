using CoffeBlend.Application.Features.Mediator.Commands.ProductPricingCommands;
using CoffeBlend.Application.Features.Mediator.Queries.ProductPricingQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductPricingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductPricingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductPricingListAsync()
        {
            var values = await _mediator.Send(new GetProductPricingQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductPricingByIdAsync(int id)
        {
            var value = await _mediator.Send(new GetProductPricingByIdQuery(id));
            return Ok(value);
        }
        [HttpGet("GetProductPricingByProductId/{id}")]
        public async Task<IActionResult> GetProductPricingByProductId(int id)
        {
            var value = await _mediator.Send(new GetProductPricingByProductIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductPricingAsync(CreateProductPricingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kayıt Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveProductPricingAsync(int id)
        {
            await _mediator.Send(new RemoveProductPricingCommand(id));
            return Ok("Kayıt Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProductPricingAsync(UpdateProductPricingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kayıt Güncellendi");
        }
    }
}
