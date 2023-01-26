using Models.Models;
using Models.Models.utilities;
using System.Windows.Forms;

namespace Interface
{
    public interface IMailSender
    {
        List<Parkplatzantrag> emailsReceiverList { get; set; }
        void ShowMailSender();
    }
}
