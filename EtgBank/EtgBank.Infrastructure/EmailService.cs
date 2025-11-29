using EtgBank.Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace EtgBank.Infrastructure
{
    public class EmailService : IEmailService
    {

        public string SendEmail(string name)
        {
            return "Email sent to " + name;
        }



    }
}
