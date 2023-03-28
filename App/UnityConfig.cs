using App.Forms;
using Framework;
using Interface;
using Microsoft.EntityFrameworkCore;
using Models.Data;
using Unity;
using Unity.Injection;
using ViewModels;

namespace App
{
    public static class UnityConfig
    {
        public static UnityContainer container { get; } = new UnityContainer();

        public static void RegisterComponents()
        {
            //Forms
            container.RegisterType<IAntragViewModel, AntragViewModel>(new InjectionConstructor(UnityConfig.container));
            container.RegisterType<IMailSender, MailSender>();
            container.RegisterType<IEmailService, EmailService>();
            container.RegisterType<IDetailView, Detail>();
            container.RegisterType<IMailServerConfiguration, MailServerConfiguration>();
            container.RegisterType<IParkingStatisticsView, ParkingStatistics>();
            container.RegisterType<IEmailSetting, EmailSetting>();


            //Tools
            container.RegisterType<IAntragService, WeightedScoring>();
            container.RegisterType<IEncryptionTool, EncryptionTool>();
            container.RegisterType<IGoogleService, GoogleService>();
            container.RegisterType<IFileLoadingForm, FileLoadingForm>();

            container.RegisterType<DbContext, ParkplatzverwaltungContext>();


        }
    }

}
