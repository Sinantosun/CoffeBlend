using CoffeBlend.Application.Dtos.MailDto;

using MimeKit;
using MailKit.Net.Smtp;
using CoffeBlend.Application.Interfaces.MailRepositories;

namespace CoffeBlend.Persistance.Repositories.MailRepositories
{
    public class MailRepository : IMailRepository
    {

        public async Task SendMailAsync(SendMailDto maildto)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress MailAddressFrom = new MailboxAddress("CoffeBlend", "aspnetcoreprojeler@gmail.com");

            mimeMessage.From.Add(MailAddressFrom);

            MailboxAddress MailAddressTo = new MailboxAddress(maildto.NameSurname, maildto.Email);

            mimeMessage.To.Add(MailAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = maildto.Content;
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = maildto.Subject;


            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("aspnetcoreprojeler@gmail.com", "mfyw wswz ojqp emra");
            await smtpClient.SendAsync(mimeMessage);
            await smtpClient.DisconnectAsync(true);


        }
    }
}
