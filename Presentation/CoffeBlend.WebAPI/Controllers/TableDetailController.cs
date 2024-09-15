using CoffeBlend.Application.Features.Mediator.Commands.TableDetailCommands;
using CoffeBlend.Application.Features.Mediator.Queries.TableDetailQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableDetailController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TableDetailController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetTableDetailListAsync()
        {
            var values = await _mediator.Send(new GetTableDetailQuery());
            return Ok(values);
        }
        [HttpGet("GetTableOrderListByTableId")]
        public async Task<IActionResult> GetTableOrderListByTableId(int id)
        {
            var values = await _mediator.Send(new GetTableOrderListByTableIdQuery(id));
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTableDetailByIdAsync(int id)
        {
            var value = await _mediator.Send(new GetTableDetailByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTableDetailAsync(CreateTableDetailCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kayıt Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveTableDetailAsync(int id)
        {
            await _mediator.Send(new RemoveTableDetailCommand(id));
            return Ok("Kayıt Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTableDetailAsync(UpdateTableDetailCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kayıt Güncellendi");
        }
    }
}
