using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectMVC
{
    public class SendEmailFromGmail : IEmailSender
    {
        public string SendEmail(string to, string subject)
        {
            return "Send From Gmail...";
        }
    }
    public class SendFromYahoo : IEmailSender
    {
        public string SendEmail(string to, string subject)
        {
            return "Send From Yahoo...";
        }
    }
}
