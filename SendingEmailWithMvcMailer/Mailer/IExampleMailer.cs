using Mvc.Mailer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendingEmailWithMvcMailer.Mailer
{
    public interface IExampleMailer
    {
        MvcMailMessage SendEmail(ExampleEmailModel model);
    }

}
