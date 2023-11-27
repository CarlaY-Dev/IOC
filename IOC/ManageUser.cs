using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    public class ManageUser
    {
        private IEmailSender Sender;
        public ManageUser(IEmailSender sender) 
        {
            this.Sender = sender;
        }
        public string RecoveryPassword()
        {
            //IEmailSender Sender = new SendEmailFromGmail();
            return Sender.SendEmail("Azadeh.yousefim@gmail.com", "Recovery password");
        }
    }
}
