using CoffeBlend.Application.Features.Mediator.Commands.ProductCommands;
using CoffeBlend.Application.Features.Mediator.Queries.ProductQueries;
using CoffeBlend.Application.Features.Mediator.Results.ProductResults;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductListAsync()
        {
            var values = await _mediator.Send(new GetProductQuery());
            return Ok(values);
        }

        [HttpGet("GetProductListWithCategory")]
        public async Task<IActionResult> GetProductListWithCategory()
        {
            var values = await _mediator.Send(new GetProductListWithCategoryQuery());
            return Ok(values);
        }

        [HttpGet("GetLast5CoffeProduct")]
        public async Task<IActionResult> GetLast5CoffeProduct()
        {
            var values = await _mediator.Send(new GetLast5CoffeProductQuery());
            return Ok(values);
        }

        [HttpGet("GetLast5Product")]
        public async Task<IActionResult> GetLast5Product()
        {
            var values = await _mediator.Send(new GetLast5ProductQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductByIdAsync(int id)
        {
            var value = await _mediator.Send(new GetProductByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductAsync(CreateProductCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kayıt Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveProductAsync(int id)
        {
            await _mediator.Send(new RemoveProductCommand(id));
            return Ok("Kayıt Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProductAsync(UpdateProductCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kayıt Güncellendi");
        }
    }
}
