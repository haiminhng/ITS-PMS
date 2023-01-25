using Interface;
using Models.Data;
using Models.Models;
using Unity;

namespace App.Forms
{
    public partial class Detail : Form, IDetailView
    {
        private IAntragViewModel _vm = UnityConfig.container.Resolve<IAntragViewModel>();


        public BindingSource SchuelerBindingSource { get; set; }
        public BindingSource AdresseBindingSource { get; set; }
        public BindingSource AntragBinDingSource { get; set; }
        public BindingSource GenehmigtStatus { get; set; }

        public Detail()
        {
            InitializeComponent();
            SchuelerBindingSource = schuelerBindingSource;
            AdresseBindingSource = adressenBindingSource;
            AntragBinDingSource = parkplatzantragBindingSource;
            GenehmigtStatus = genehmigtstatusBindingSource;

            btnSave.Click += delegate { _vm.Save();  };
            btnCancle.Click += delegate { this.Hide(); };
        }


        public void ShowDetail()
        {
            this.ShowDialog();
        }


       
    }
}
