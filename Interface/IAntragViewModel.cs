using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace Interface
{
    public interface IAntragViewModel
    {
        public WebView2 webView { get; set; }
        public BindingSource AntragBindingSource { get; set; }
        public BindingSource SchuelerBindingSource { get; set; }
        public BindingSource AdresseBindingSource { get; set; }

        Task LoadAsync();
        void Delete();
        void First();
        void Last();
        void New();
        void Next();
        void Previous();
        void Save();
        void DataGridView_CellClick( );
        void DataGridView_CellFormatting();
        void DataGridView_CellDoubleClick(IDetailView detail);
    }
}
