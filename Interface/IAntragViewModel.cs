using Microsoft.Web.WebView2.WinForms;
using System.Windows.Forms;

namespace Interface
{
    public interface IAntragViewModel
    {
        public TextBox searchBox { get; set; }

        public TextBox untisPathBox { get; set; }
        public WebView2 webView { get; set; }
        public DataGridView parkPlatzAntragView { get; set; }
        public BindingSource AntragBindingSource { get; set; }
        public BindingSource SchuelerBindingSource { get; set; }
        public BindingSource AdresseBindingSource { get; set; }
        public BindingSource GenehmigtStatus { get; set; }


        Task LoadAsync();
        Task CalcNewRouteData();
        void Search();
        void Delete();
        void First();
        void Last();
        void New();
        void Next();
        void Previous();
        void Save();
        void ShowDetail(IDetailView detailView);
        void ShowParkingStatistics(IParkingStatisticsView parkingStatisticsView);
        void ShowMailSender(IMailSender mailSender);
        void ShowEmailSetting(IEmailSetting emailSetting);
        void DataGridView_CellClick();
        void DataGridView_CellFormatting();

        //Parkplatz statistik
        void LoadUntisStunde();
    }
}
