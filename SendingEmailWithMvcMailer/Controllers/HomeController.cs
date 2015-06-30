using SendingEmailWithMvcMailer.Mailer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SendingEmailWithMvcMailer.Controllers
{
    public class HomeController : Controller
    {
        private IExampleMailer _sampleMailer = new ExampleMailer();
        public IExampleMailer SampleMailer
        {
            get { return _sampleMailer; }
            set { _sampleMailer = value; }
        }

        public ActionResult Index()
        {
            var EmailContent = new ExampleEmailModel();
            EmailContent.To = "somebody@email.com";
            EmailContent.Fname = "First";
            EmailContent.Lname = "Last";
            EmailContent.Subject = "Testing email";
            EmailContent.FormatId = 1;

            SampleMailer.SendEmail(EmailContent).Send();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}