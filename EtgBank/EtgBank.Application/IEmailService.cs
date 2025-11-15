using System;
using System.Collections.Generic;
using System.Text;

namespace EtgBank.Application
{
    public interface IEmailService
    {
        string SendEmail(string name);
    }
}
