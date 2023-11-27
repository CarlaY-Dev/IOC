using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    public class SendEmailFromGmail : IEmailSender
    {
        public string SendEmail(string to, string subject)
        {
            return "Send From Gmail...";
        }
    }
    class SendFromYahoo : IEmailSender
    {
        public string SendEmail(string to, string subject)
        {
            return "Send From Yahoo...";
        }
    }
}
