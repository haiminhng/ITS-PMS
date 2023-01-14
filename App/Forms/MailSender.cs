using Interface;

namespace App.Forms
{
    public partial class MailSender : Form, IMailSender
    {
        public MailSender()
        {
            InitializeComponent();
        }

        public void ShowMailSender()
        {
            this.ShowDialog();
        }
    }
}
