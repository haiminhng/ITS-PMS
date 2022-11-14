using Interface;
using Unity;
using ViewModels;

namespace App
{
    static class Config
    {
        public static UnityContainer Container { get; private set; } = new UnityContainer();
        public static void Register()
        {
            Container.RegisterType<IAntragViewModel, AntragViewModel>();
        }
    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Config.Register();
            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();
            Application.Run(new Antrag());
        }
    }
}