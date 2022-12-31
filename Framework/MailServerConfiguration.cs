﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Interface;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Framework
{
    public class MailServerConfiguration : IMailServerConfiguration
    {

        public string SmtpServer { get; set; } = ConfigurationManager.AppSettings["SmtpServer"] ?? string.Empty;
        public int Port { get; set; } = int.TryParse(ConfigurationManager.AppSettings["Port"], out int port) ? port : 0;
        public string SenderEmail { get; set; } = ConfigurationManager.AppSettings["SenderEmail"] ?? string.Empty;
        public string Password { get; set; } = ConfigurationManager.AppSettings["Password"] ?? string.Empty;
        public bool EnableSsl { get; set; } = bool.TryParse(ConfigurationManager.AppSettings["EnableSsl"], out bool enableSsl) ? enableSsl : false;
    
    }
}
