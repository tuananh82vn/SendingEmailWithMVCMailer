using Mvc.Mailer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SendingEmailWithMvcMailer.Mailer
{
    public class ExampleMailer : MailerBase, IExampleMailer
    {
        public ExampleMailer()
        {
            MasterName = "_Layout";
        }

        public virtual MvcMailMessage SendEmail(ExampleEmailModel model)
        {
            var mailMessage = new MvcMailMessage
            {
                Subject = model.Subject
            };

            mailMessage.To.Add(model.To);

            if (model.Bcc != null)
                mailMessage.Bcc.Add(model.Bcc);

            if (model.attachmentPath1 != null)
                mailMessage.Attachments.Add(new Attachment(model.attachmentPath1));

            // Use a strongly typed model
            ViewData = new ViewDataDictionary(model);
            if (model.FormatId == 1)
            {
                PopulateBody(mailMessage, "Template1", null);
            }
            else
                if (model.FormatId == 2)
                {
                    PopulateBody(mailMessage, "Template2", null);
                }

            return mailMessage;
        }
    }

}
