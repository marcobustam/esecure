using System;
using System.Collections.Generic;
using System.Text;

namespace Bbs.Mailer
{
    public class MailSender
    {
        public int MailSenderID { get; set; }
        public string MailSenderFrom { get; set; }
        public string MailSenderTo { get; set; }
        public string MailSenderSubject { get; set; }
        public string MailSenderMessage { get; set; }
        public DateTime Timestamp { get; set; }

        public MailSender()
        {
            MailSenderFrom = "";
            MailSenderTo = "";
            MailSenderSubject = "";
            MailSenderMessage = "";
        }
    }
}
