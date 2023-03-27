using Microsoft.Web.WebView2.WinForms;
using System.Windows.Forms;

namespace Interface
{
    public interface IAntragViewModel
    {
        public TextBox searchBox { get; set; }
        public WebView2 webView { get; set; }

        public ContextMenuStrip contextMenuStrip { get; set; }

        public DataGridView parkPlatzAntragView { get; set; }
        public BindingSource AntragBindingSource { get; set; }
        public BindingSource SchuelerBindingSource { get; set; }
        public BindingSource AdresseBindingSource { get; set; }
        public BindingSource GenehmigtStatus { get; set; }

        public event EventHandler CountsUpdated;
        public int approvedCount { get; }
        public int rejectedCount { get; }
        public int inProgressCount { get; }
        public int waitListCount { get; }


        Task LoadAsync();
        Task CalcNewRouteData();
        void Search();
        void Delete();
        void First();
        void Last();
        void New();
        void Next();
        void Previous();
        Task SaveAsync();
        void ShowDetail(IDetailView detailView, EventHandler CountsUpdated);
        void ShowParkingStatistics(IParkingStatisticsView parkingStatisticsView);
        void ShowMailSender(IMailSender mailSender);
        void ShowEmailSetting(IEmailSetting emailSetting);
        void DataGridView_CellClick();
        void DataGridView_CellFormatting();

        void contextMenuStripItemClicked();
    }
}
