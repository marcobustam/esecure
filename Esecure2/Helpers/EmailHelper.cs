using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Net.Http;
using Esecure2.Data;
using EsecureModel.Config;

namespace EsecureWebApp.Helpers 
{
    public class EmailHelper
    {
        public static IConfiguration _configuration { get; private set; }
        private readonly ApplicationDbContext _context;
        public EmailHelper(IConfiguration configuration, ApplicationDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }
        static string senderAddress = "admin@esafy.cl";

        // Set the receiver's email address here.
        static string receiverAddress = "marco.bustam@gmail.com";

        // Set the SMTP user name in App.config 
        static string smtpUserName = null;

        // Set the SMTP password in App.config 
        static string smtpPassword = null;

        static string host = null;

        static int port = 25;
        public bool SendEmail()
        {
            if (CheckRequiredFields("WebConfiguration", _context))
            {
                var smtpClient = new SmtpClient(host, port);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(smtpUserName, smtpPassword);

                var message = new MailMessage(
                                from: senderAddress,
                                to: receiverAddress,
                                subject: "Sample email using SMTP Interface",
                                body: "Sample email.");

                try
                {
                    // Console.WriteLine("Sending email using SMTP interface...");
                    smtpClient.Send(message);
                    // Console.WriteLine("The email was sent successfully.");
                }
                catch (Exception ex)
                {
                    // Console.WriteLine("The email was not sent.");
                    // Console.WriteLine("Error message: " + ex.Message);
                }
            }

            // Console.Write("Press any key to continue...");
            // Console.ReadKey();
            return true;
        }
        public bool SendEmail(string from, string to, string about, string body)
        {
            if (CheckRequiredFields("WebConfiguration", _context))
            {
                var smtpClient = new SmtpClient(host, port);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(smtpUserName, smtpPassword);

                var message = new MailMessage(
                                from: from,
                                to: to,
                                subject: about,
                                body: body);

                try
                {
                    // Console.WriteLine("Sending email using SMTP interface...");
                    smtpClient.Send(message);

                    // Console.WriteLine("The email was sent successfully.");
                }
                catch (Exception ex)
                {
                    // Console.WriteLine("The email was not sent.");
                    // Console.WriteLine("Error message: " + ex.Message);
                }
            }

            // Console.Write("Press any key to continue...");
            // Console.ReadKey();
            return true;
        }
        public bool SendEmail(string from, string to, string about, HttpContent body)
        {
            if (CheckRequiredFields("WebConfiguration", _context))
            {
                var smtpClient = new SmtpClient(host, port);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(smtpUserName, smtpPassword);
                // var html = await body.ReadAsStringAsync();
                var message = new MailMessage(
                                from: from,
                                to: to,
                                subject: about,
                                body:"nada" );

                try
                {
                    // Console.WriteLine("Sending email using SMTP interface...");
                    smtpClient.Send(message);
                    // Console.WriteLine("The email was sent successfully.");
                }
                catch (Exception ex)
                {
                    // Console.WriteLine("The email was not sent.");
                    // Console.WriteLine("Error message: " + ex.Message);
                }
            }

            // Console.Write("Press any key to continue...");
            // Console.ReadKey();
            return true;
        }
        public bool SendEmail(string from, string to, string about, string body, object FileAttached)
        {
            if (CheckRequiredFields("WebConfiguration", _context))
            {
                var smtpClient = new SmtpClient(host, port);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(smtpUserName, smtpPassword);

                var message = new MailMessage(
                                from: from,
                                to: to,
                                subject: about,
                                body: body);

                try
                {
                    // Console.WriteLine("Sending email using SMTP interface...");
                    smtpClient.Send(message);
                    // Console.WriteLine("The email was sent successfully.");
                }
                catch (Exception ex)
                {
                    // Console.WriteLine("The email was not sent.");
                    // Console.WriteLine("Error message: " + ex.Message);
                }
            }

            // Console.Write("Press any key to continue...");
            // Console.ReadKey();
            return true;
        }

        static bool CheckRequiredFields(string source, ApplicationDbContext context)
        {
            if(!String.IsNullOrEmpty(source))
            {
                if (source== "WebConfiguration")
                {
                    List<WebConfiguration> config = context.WebConfiguration.Where(co=>co.WebConfigurationGroup== "AwsSes").ToList();


                    if (config.Count == 0)
                    {
                        return false;
                    }
                    smtpUserName = config.Where(co => co.WebConfigurationName == "SmtpUsername").FirstOrDefault().WebConfigurationValue.ToString();
                    //smtpUserName = section.GetValue<string>("AwsSesSmtpUserName");
                    if (string.IsNullOrEmpty(smtpUserName))
                    {
                        // Console.WriteLine("AwsSesSmtpUserName is not set in the App.config file.");
                        return false;
                    }

                    smtpPassword = config.Where(co => co.WebConfigurationName == "SmtpPassword").FirstOrDefault().WebConfigurationValue.ToString();
                    if (string.IsNullOrEmpty(smtpPassword))
                    {
                        // Console.WriteLine("AwsSesSmtpPassword is not set in the App.config file.");
                        return false;
                    }
                    host = config.Where(co => co.WebConfigurationName == "SmtpHostName").FirstOrDefault().WebConfigurationValue.ToString();
                    if (string.IsNullOrEmpty(host))
                    {
                        // Console.WriteLine("host is not set in the App.config file.");
                        return false;
                    }
                    if (string.IsNullOrEmpty(senderAddress))
                    {
                        // Console.WriteLine("The variable senderAddress is not set.");
                        return false;
                    }
                    if (string.IsNullOrEmpty(receiverAddress))
                    {
                        // Console.WriteLine("The variable receiverAddress is not set.");
                        return false;
                    }
                }
                else
                {
                    var section = _configuration.GetSection("SimpleEmailServices");

                    if (section == null)
                    {
                        return false;
                    }

                    smtpUserName = section.GetValue<string>("AwsSesSmtpUserName");
                    if (string.IsNullOrEmpty(smtpUserName))
                    {
                        // Console.WriteLine("AwsSesSmtpUserName is not set in the App.config file.");
                        return false;
                    }

                    smtpPassword = section.GetValue<string>("AwsSesSmtpPassword");
                    if (string.IsNullOrEmpty(smtpPassword))
                    {
                        // Console.WriteLine("AwsSesSmtpPassword is not set in the App.config file.");
                        return false;
                    }
                    host = section.GetValue<string>("SesHost");
                    if (string.IsNullOrEmpty(host))
                    {
                        // Console.WriteLine("host is not set in the App.config file.");
                        return false;
                    }
                    if (string.IsNullOrEmpty(senderAddress))
                    {
                        // Console.WriteLine("The variable senderAddress is not set.");
                        return false;
                    }
                    if (string.IsNullOrEmpty(receiverAddress))
                    {
                        // Console.WriteLine("The variable receiverAddress is not set.");
                        return false;
                    }
                }
            }

            

            return true;
        }
    }
}
