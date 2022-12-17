using Interface;

namespace App.Forms
{
    public partial class Detail : Form, IDetailView
    {
        public Detail()
        {
            InitializeComponent();
        }

        public BindingSource AntragBindingSource { get; set; }
        public BindingSource SchuelerBindingSource { get; set; }
        public BindingSource AdresseBindingSource { get; set; }

        public void ShowModal()
        {
            this.Show();
        }
    }
}
