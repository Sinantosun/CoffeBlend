using CoffeBlend.Application.Features.Mediator.Commands.GaleryCommands;
using CoffeBlend.Application.Features.Mediator.Queries.GaleryQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GaleriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GaleriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetGaleryListAsync()
        {
            var values = await _mediator.Send(new GetGaleryQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetGaleryByIdAsync(int id)
        {
            var value = await _mediator.Send(new GetGaleryByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateGaleryAsync(CreateGaleryCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kayıt Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveGaleryAsync(int id)
        {
            await _mediator.Send(new RemoveGaleryCommand(id));
            return Ok("Kayıt Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateGaleryAsync(UpdateGaleryCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kayıt Güncellendi");
        }
    }
}
