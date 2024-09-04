using CoffeBlend.Application.Interfaces.GenericRepository;


using CoffeBlend.Domain.Entites;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoffeBlend.Application.Features.Mediator.Queries.AboutQueries;
using CoffeBlend.Application.Features.Mediator.Commands.AboutCommands;

namespace CoffeBlend.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public AboutsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAboutListAsync()
        {
            var values = await _mediator.Send(new GetAboutQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAboutByIdAsync(int id)
        {
            var value = await _mediator.Send(new GetAboutByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAboutAsync(CreateAboutCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kayıt Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveAboutAsync(int id)
        {
            await _mediator.Send(new RemoveAboutCommand(id));
            return Ok("Kayıt Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAboutAsync(UpdateAboutCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kayıt Güncellendi");
        }
    }
}
