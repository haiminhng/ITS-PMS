using Interface;
using Unity;


namespace App.Forms
{
    public partial class EmailSetting : Form, IEmailSetting
    {
        private IMailServerConfiguration _mailServer = UnityConfig.container.Resolve<IMailServerConfiguration>();
        private IEncryptionTool _encryptionTool = UnityConfig.container.Resolve<IEncryptionTool>();
        private string _originalPassword;

        public EmailSetting()
        {
            InitializeComponent();
            InitializeSetting();
        }

        public void ShowEmailSetting()
        {
            this.ShowDialog();
        }

        public void InitializeSetting() {
            textBoxSmtpServer.Text = _mailServer.SmtpServer;
            textBoxSenderEmail.Text = _mailServer.SenderEmail;
            textBoxPassword.Text = _mailServer.Password;
            checkBoxEnableSsl.Checked = _mailServer.EnableSsl;
            textBoxPort.Text = _mailServer.Port.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _mailServer.SmtpServer = textBoxSmtpServer.Text;
            _mailServer.SenderEmail = textBoxSenderEmail.Text;
            _mailServer.Password = textBoxPassword.Text;
            _mailServer.EnableSsl = checkBoxEnableSsl.Checked;
            _mailServer.Port = int.Parse(textBoxPort.Text);
            
            try
            {
                _mailServer.SaveConfiguration();
                MessageBox.Show("Erfolgreich gespeichert");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim speichern " + ex.Message);
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
