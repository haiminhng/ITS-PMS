namespace Interface
{
    public interface IMailServerConfiguration
    {
        string SmtpServer { get; set; }
        int Port { get; set; }
        string SenderEmail { get; set; }
        string Password { get; set; }
        bool EnableSsl { get; set; }
        void SaveConfiguration();
    }
}
