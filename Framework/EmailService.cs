using Interface;
using Models.Models.utilities;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace Framework
{
    public class EmailService : IEmailService
    {


        public void Send(Email email)
        {
            // Set the SMTP server and credentials
            string smtpServer = ConfigurationManager.AppSettings["SmtpServer"];
            int port = int.Parse(ConfigurationManager.AppSettings["Port"]);
            string senderEmail = ConfigurationManager.AppSettings["SenderEmail"];
            string password = ConfigurationManager.AppSettings["Password"];
            bool enableSsl = bool.Parse(ConfigurationManager.AppSettings["EnableSsl"]);

            EmailConfiguration emailConfig = new EmailConfiguration(smtpServer, port, senderEmail, password, enableSsl);

            email.From = emailConfig.SenderEmail;

            SmtpClient client = new SmtpClient();
            client.Host = emailConfig.SmtpServer;
            client.Port = emailConfig.Port;
            client.EnableSsl = emailConfig.EnableSsl;
            client.Credentials = new NetworkCredential(emailConfig.SenderEmail, emailConfig.Password); 

            MailMessage message = new MailMessage();
            message.From = new MailAddress(emailConfig.SenderEmail); 
            message.To.Add(email.To); 
            message.Subject = email.Subject; 
            message.Body = email.Body; 

            client.Send(message);
        }
    }
}
