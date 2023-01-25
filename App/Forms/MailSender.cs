using Interface;
using Models.Models.utilities;
using System.Net.Mail;
using Unity;

namespace App.Forms
{
    public partial class MailSender : Form, IMailSender
    {
        private Email email;
        private IEmailService _emailService = UnityConfig.container.Resolve<IEmailService>();

        public MailSender()
        {
            InitializeComponent();
        }
        
        public void ShowMailSender()
        {
            this.ShowDialog();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            InitializeEmail();
            try
            {
                _emailService.Send(this.email);
                MessageBox.Show("Email sent successfully.");
            }
            catch (SmtpFailedRecipientsException ex)
            {
                MessageBox.Show("Failed to send email to some recipients." + ex.Message);
            }
            catch (SmtpException ex)
            {
                MessageBox.Show("Error while sending email." + ex.Message);
            }
        }


        public void InitializeEmail() { 
            email = new Email();
            email.To = tbEmailTo.Text; 
            email.Subject = tbEmailSubject.Text;
            email.From = tbEmailFrom.Text;
            email.Body = rtbEmailBody.Text;
           
        }
    }
}
