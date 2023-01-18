using Interface;
using Models.Models;

namespace App.Forms
{
    public partial class Detail : Form, IDetailView
    {

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
        }



        public void ShowDetail()
        {
            this.ShowDialog();
        }


    }
}
