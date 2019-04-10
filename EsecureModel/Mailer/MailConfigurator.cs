using System;
using System.Collections.Generic;
using System.Text;

namespace EsecureModel.Mailer
{
    public class MailConfigurator
    {
        public int MailConfiguratorID { get; set; }
        public string MailConfiguratorHost { get; set; }
        public int MailConfiguratorPort { get; set; }
        public string MailConfiguratorUserName { get; set; }
        public string MailConfiguratorUserPassword { get; set; }

        public bool CheckValues()
        {
            return (String.IsNullOrEmpty(MailConfiguratorHost) || String.IsNullOrEmpty(MailConfiguratorUserName) || String.IsNullOrEmpty(MailConfiguratorUserPassword) || (MailConfiguratorPort >= 0));
        }
    }
}
