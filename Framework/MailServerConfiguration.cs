
using Interface;
using System.Configuration;

namespace Framework
{
    public class MailServerConfiguration : IMailServerConfiguration
    {
        
        public string SmtpServer { get; set; } = ConfigurationManager.AppSettings["SmtpServer"] ?? "Fehler";
        public int Port { get; set; } = int.TryParse(ConfigurationManager.AppSettings["Port"], out int port) ? port : 0;
        public string SenderEmail { get; set; } = ConfigurationManager.AppSettings["SenderEmail"] ?? string.Empty;
        public string Password { get; set; } = ConfigurationManager.AppSettings["Password"] ?? string.Empty;
        public bool EnableSsl { get; set; } = bool.TryParse(ConfigurationManager.AppSettings["EnableSsl"], out bool enableSsl) ? enableSsl : false;

        public void SaveConfiguration()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["SmtpServer"].Value = this.SmtpServer;
            config.AppSettings.Settings["Port"].Value = this.Port.ToString();
            config.AppSettings.Settings["SenderEmail"].Value = this.SenderEmail;
            config.AppSettings.Settings["Password"].Value = this.Password;
            config.AppSettings.Settings["EnableSsl"].Value = this.EnableSsl.ToString();
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

    }
}


/*
using Interface;
using System.Configuration;

namespace Framework
{
    public class MailServerConfiguration : IMailServerConfiguration
    {
        private IEncryptionTool _encryptionTool;

        public string SmtpServer { get; set; }
        public int Port { get; set; }
        public string SenderEmail { get; set; }
        public string Password { get; set; }
        public bool EnableSsl { get; set; }

        public MailServerConfiguration(IEncryptionTool encryptionTool)
        {
            _encryptionTool = encryptionTool;

            SmtpServer = ConfigurationManager.AppSettings["SmtpServer"];
            Port = int.TryParse(ConfigurationManager.AppSettings["Port"], out int port) ? port : 0;
            SenderEmail = ConfigurationManager.AppSettings["SenderEmail"];
            Password = ConfigurationManager.AppSettings["Password"];
            EnableSsl = bool.TryParse(ConfigurationManager.AppSettings["EnableSsl"], out bool enableSsl) ? enableSsl : false;

            if (string.IsNullOrEmpty(SmtpServer) || string.IsNullOrEmpty(SenderEmail) || string.IsNullOrEmpty(Password))
            {
                Save("demo-smtp-server", 1234, "demo@example.com", "demo-password", true);
            }
            else
            {
                //decrypt password
                Password = _encryptionTool.Decrypt(Password);
            }
        }
        public void Save(string smtpServer, int port, string senderEmail, string password, bool enableSsl)
        {
            if (_encryptionTool == null)
            {
                throw new NullReferenceException("Encryption tool is not set.");
            }
            SmtpServer = smtpServer;
            Port = port;
            SenderEmail = senderEmail;
            Password = _encryptionTool.Encrypt(password);
            EnableSsl = enableSsl;

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["SmtpServer"].Value = SmtpServer;
            config.AppSettings.Settings["Port"].Value = Port.ToString();
            config.AppSettings.Settings["SenderEmail"].Value = SenderEmail;
            config.AppSettings.Settings["Password"].Value = Password;
            config.AppSettings.Settings["EnableSsl"].Value = EnableSsl.ToString();

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }




    }
}
*/
