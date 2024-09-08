using CoffeBlend.Application.Features.Mediator.Commands.TableCommands;
using CoffeBlend.Application.Features.Mediator.Queries.TableQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TablesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TablesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetTableListAsync()
        {
            var values = await _mediator.Send(new GetTableQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTableByIdAsync(int id)
        {
            var value = await _mediator.Send(new GetTableByIdQuery(id));
            return Ok(value);
        }
        [HttpGet("GetActiveTables")]
        public async Task<IActionResult> GetActiveTables()
        {
            var value = await _mediator.Send(new GetActiveTableQuery());
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTableAsync(CreateTableCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kayıt Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveTableAsync(int id)
        {
            await _mediator.Send(new RemoveTableCommand(id));
            return Ok("Kayıt Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTableAsync(UpdateTableCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kayıt Güncellendi");
        }
    }
}
