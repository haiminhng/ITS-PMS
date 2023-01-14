using App.Forms;
using Framework;
using Interface;
using Unity;
using ViewModels;

namespace App
{
    public static class UnityConfig
    {
        public static UnityContainer container = new UnityContainer();

        public static void RegisterComponents()
        {

            container.RegisterType<IAntragViewModel, AntragViewModel>();
            container.RegisterType<IMailSender, MailSender>();
            container.RegisterType<IDetailView, Detail>();
            container.RegisterType<IMailServerConfiguration, MailServerConfiguration>();
            container.RegisterType<IEmailSetting, EmailSetting>();
            container.RegisterType<IEncryptionTool, EncryptionTool>();

        }
    }

}
