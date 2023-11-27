using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NinjectMVC.Controllers
{
    public class HomeController : Controller
    {
        private IEmailSender Sender;
        public HomeController(IEmailSender sender)
        {
            this.Sender = sender;
        }

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = Sender.SendEmail("a@a.com", "subject");
            return View();
        }
    }
}