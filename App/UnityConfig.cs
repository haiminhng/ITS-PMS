using App.Forms;
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
            container.RegisterType<IDetailView, DetailViewModel>();
            container.RegisterType<IMailSender, MailSenderViewModel>();

        }
    }

}
