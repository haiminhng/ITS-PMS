using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.utilities
{
    public class Email
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public void Send()
        {
            // Set the SMTP server and credentials
            string smtpServer = "smtp.example.com";
            string username = "username";
            string password = "password";

            // Create the mail message object
            MailMessage message = new MailMessage(From, To, Subject, Body);

            // Set the SMTP client and send the email
            SmtpClient client = new SmtpClient(smtpServer);
            client.Credentials = new NetworkCredential(username, password);
            client.Send(message);
        }
    }
}
