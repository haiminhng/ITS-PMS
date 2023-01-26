using Interface;
using Models.Models;
using Models.Models.utilities;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using Unity;

namespace App.Forms
{
    public partial class MailSender : Form, IMailSender
    {
        private Email _email;
        private IEmailService _emailService = UnityConfig.container.Resolve<IEmailService>();
        private IMailServerConfiguration _mailServer = UnityConfig.container.Resolve<IMailServerConfiguration>();

        public List<Parkplatzantrag> emailsReceiverList { get; set; }

        public MailSender()
        {
            InitializeComponent();
            emailsReceiverList = new List<Parkplatzantrag>();
            tbEmailFrom.Text = _mailServer.SenderEmail;
        }

        public void ShowMailSender()
        {
            foreach (var email in emailsReceiverList)
            {
                if (email != null)
                {
                    tbEmailTo.Text += GetEmailForList();
                }
            }

            this.ShowDialog();
           
        }
        private string GetEmailForList()
        {
            string emailString;

            if (emailsReceiverList.Count > 1)
                emailString = String.Join(
                    ", ", 
                    emailsReceiverList.Where(x => x != null)
                    .Select(x => x.Schueler.Email.ToString())
                    .Take(emailsReceiverList.Count - 1));
            else
                emailString = 
                    emailsReceiverList
                    .Where(x => x != null)
                    .Select(x => x.Schueler.Email
                    .ToString())
                    .FirstOrDefault() ?? "";

            return emailString;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {

            InitializeEmail();
            try
            {
                _emailService.Send(this._email);
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
           
            _email = new Email();
            _email.To = tbEmailTo.Text;
            _email.Subject = tbEmailSubject.Text;
            _email.From = tbEmailFrom.Text;
            _email.Body = rtbEmailBody.Text;
        }
    }
}
