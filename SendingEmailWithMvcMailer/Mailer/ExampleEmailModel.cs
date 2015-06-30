using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendingEmailWithMvcMailer.Mailer
{
    public class ExampleEmailModel
    {
        public string Subject { get; set; }
        public string To { get; set; }
        public string Bcc { get; set; }

        public string attachmentPath1 { get; set; }
        public string attachmentPath2 { get; set; }
        public string attachmentPath3 { get; set; }

        public string Link { get; set; }

        public string Title { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public String FullName
        {
            get
            {
                return Title + " " + Fname + " " + Lname;
            }
        }

        public int FormatId { get; set; }
    }

}
