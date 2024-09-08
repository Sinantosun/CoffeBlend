using CoffeBlend.Application.Dtos.MailDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Interfaces.MailRepositories
{
    public interface IMailRepository 
    {
         Task SendMailAsync(SendMailDto maildto);
    }
}
