using CoffeBlend.Application.Features.Mediator.Commands.CategoryCommands;
using CoffeBlend.Application.Features.Mediator.Queries.CategoryQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategoriesListAsync()
        {
            var values = await _mediator.Send(new GetCategoryQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoriesByIdAsync(int id)
        {
            var value = await _mediator.Send(new GetCategoryByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategoriesAsync(CreateCategoryCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kayıt Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveCategoriesAsync(int id)
        {
            await _mediator.Send(new RemoveCategoryCommand(id));
            return Ok("Kayıt Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategoriesAsync(UpdateCategoryCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kayıt Güncellendi");
        }
    }
}
