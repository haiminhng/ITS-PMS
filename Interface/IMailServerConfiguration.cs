using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IMailServerConfiguration
    {
        string SmtpServer { get; set; }
        int Port { get; set; }
        string SenderEmail { get; set; }
        string Password { get; set; }
        bool EnableSsl { get; set; }
    }
}
