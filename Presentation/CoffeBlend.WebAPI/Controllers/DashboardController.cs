using CoffeBlend.Application.Features.Mediator.Commands.AboutCommands;
using CoffeBlend.Application.Features.Mediator.Queries.AboutQueries;
using CoffeBlend.Application.Features.Mediator.Queries.AdminDashboardQueries;
using CoffeBlend.Application.Features.Mediator.Queries.GetDashboardChartQueries;
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

        [HttpGet("GetAdminDashboardTodayBalance")]
        public async Task<IActionResult> GetAdminDashboardTodayBalance()
        {
            var values = await _mediator.Send(new GetAdminDashboardTodayBalanceQuery());
            return Ok(values);
        }
        [HttpGet("GetAdminDashboardWidgetStatistics")]
        public async Task<IActionResult> GetAdminDashboardWidgetStatistics()
        {
            var values = await _mediator.Send(new GetAdminWidgetStatisticQuery());
            return Ok(values);
        }
        [HttpGet("GetDashboardChart")]
        public async Task<IActionResult> GetDashboardChart()
        {
            var values = await _mediator.Send(new GetDashboardChartQuery());
            return Ok(values);
        }
    }
}
