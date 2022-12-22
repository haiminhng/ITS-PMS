using Microsoft.Web.WebView2.WinForms;
using System.Windows.Forms;

namespace Interface
{
    public interface IAntragViewModel
    {
        public TextBox searchBox { get; set; }
        public WebView2 webView { get; set; }
        public DataGridView parkPlatzAntragView { get; set; }
        public BindingSource AntragBindingSource { get; set; }
        public BindingSource SchuelerBindingSource { get; set; }
        public BindingSource AdresseBindingSource { get; set; }

        Task LoadAsync();
        Task CalcNewRouteData();
        void Delete();
        void First();
        void Last();
        void New();
        void Next();
        void Previous();
        void Save();
        void DataGridView_CellClick();
        void DataGridView_CellFormatting();
    }
}
