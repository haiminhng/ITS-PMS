using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.utilities
{
    public class EmailConfiguration
    {
        public string SmtpServer { get; set; }
        public int Port { get; set; }
        public string SenderEmail { get; set; }
        public string Password { get; set; }
        public bool EnableSsl { get; set; }

        public EmailConfiguration(string smtpServer, int port, string senderEmail, string password, bool enableSsl)
        {
            SmtpServer = smtpServer;
            Port = port;
            SenderEmail = senderEmail;
            Password = password;
            EnableSsl = enableSsl;
        }
    }
}
