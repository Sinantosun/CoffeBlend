
using CoffeBlend.Application.Dtos.MailDto;
using CoffeBlend.Application.Features.Mediator.Commands.ReservationCommands;
using CoffeBlend.Application.Features.Mediator.Queries.ReservationQueries;
using CoffeBlend.Application.Interfaces.MailRepositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CoffeBlend.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMailRepository _mailService;

        public ReservationsController(IMediator mediator, IMailRepository mailService)
        {
            _mediator = mediator;
            _mailService = mailService;
        }

        [HttpGet]
        public async Task<IActionResult> GetReservationsListAsync()
        {
            var values = await _mediator.Send(new GetReservationQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetReservationsByIdAsync(int id)
        {
            var value = await _mediator.Send(new GetReservationByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateReservationsAsync(CreateReservationCommand command)
        {
            await _mediator.Send(command);
            await _mailService.SendMailAsync(new SendMailDto
            {
                Content = "Merhaba <span style=text-transfrom:capitalize>" + command.NameSurname + "</span>,<br/><br/>" + command.Date + " Tarihi için CoffeBlend Rezervasyonunuz alındı en kısa süre içinde rezervasyonunuz için size dönüş sağlanacaktır<br/><br/> teşekkürler!",
                Subject = "CoffeBlend Rezervasyon",
                NameSurname = command.NameSurname,
                Email = command.Email,
            });
            return Ok("Kayıt Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveReservationsAsync(int id)
        {
            await _mediator.Send(new RemoveReservationCommand(id));
            return Ok("Kayıt Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateReservationsAsync(UpdateReservationCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kayıt Güncellendi");
        }


        [HttpGet("GetApprovedReservation")]
        public async Task<IActionResult> GetApprovedReservation()
        {
            var values = await _mediator.Send(new GetApprovedReservationQuery());
            return Ok(values);
        }

        [HttpGet("GetCancelledReservation")]
        public async Task<IActionResult> GetCancelledReservation()
        {
            var values = await _mediator.Send(new GetCanceledReservationQuery());
            return Ok(values);
        }

        [HttpGet("ApproveReservation/{id}")]
        public async Task<IActionResult> ApproveReservation(int id)
        {
            Random rnd = new Random();
            int Code = rnd.Next(100000, 999999);
            var value = await _mediator.Send(new GetReservationByIdQuery(id));
            await _mailService.SendMailAsync(new SendMailDto
            {
                Content = "Merhaba <span style=text-transform:capitalize>" + value.NameSurname + "</span>,<br/><br/>" + value.Date + " Tarihi için CoffeeBlend'de rezervasyonunuzu başarıyla aldık ve onayladık!  <br/><br/> İşte Rezervasyon Detaylarınız " +"<ul>" +"<li>Tarih :" +value.Date.ToShortDateString() + " </li>" +"<li>Saat :" + value.Date.ToShortTimeString() + " </li>" + "<li>Rezervasyon Kodunuz :" + Code + " </li></ul>" + "Sizi aramızda görmek için sabırsızlanıyoruz! Eğer rezervasyonunuzda herhangi bir değişiklik yapmanız gerekiyorsa veya ek bir talebiniz varsa, lütfen bizimle telefon numaralarımız web sitemiz veya email adreslerimiz üzerinden iletişime geçin.! <br><br> İyi Günler Dileriz!<br> CoffeBlend Ekibi",
                Subject = "CoffeBlend Rezervasyon Rezervasyon Durumu",
                NameSurname = value.NameSurname,
                Email = value.Email,
            });

            await _mediator.Send(new ApproveReseravtionCommand(id));
            return Ok();
        }

        [HttpGet("CancelReservation/{id}")]
        public async Task<IActionResult> CancelReservation(int id)
        {
            await _mediator.Send(new CancelReservationCommand(id));
            return Ok();
        }

        [HttpGet("GetConfirmationReseravtion")]
        public async Task<IActionResult> GetConfirmationReseravtion()
        {
            var value = await _mediator.Send(new GetConfirmationReservationQuery());
            return Ok(value);
        }
    }
}
