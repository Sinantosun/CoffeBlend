using CoffeBlend.Application.Features.Mediator.Commands.AboutCommands;
using CoffeBlend.Application.Features.Mediator.Queries.AboutQueries;
using CoffeBlend.Application.Features.Mediator.Queries.AdminDashboardQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DashboardController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAboutListAsync()
        {
            var values = await _mediator.Send(new GetAdminDashboardTodayBalanceQuery());
            return Ok(values);
        }
    }
}
