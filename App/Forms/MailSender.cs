using Interface;
using Unity;

namespace App.Forms
{
    public partial class MailSender : Form
    {
        private IMailSender _mailSender = UnityConfig.container.Resolve<IMailSender>();

        public MailSender()
        {
            InitializeComponent();
        }
    }
}
