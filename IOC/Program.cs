using Ninject;
using System;

namespace IOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ManageUser manageUser = new ManageUser(new SendEmailFromGmail());
            //Console.WriteLine(manageUser.RecoveryPassword());
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IEmailSender>().To<SendFromYahoo>();

            ManageUser user = new ManageUser(ninjectKernel.Get<IEmailSender>());
            Console.WriteLine(user.RecoveryPassword());

        }
    }
}
