using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Application.Dtos.MailDto
{
    public class SendMailDto
    {
        public string NameSurname { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public string Email { get; set; }
    }
}
