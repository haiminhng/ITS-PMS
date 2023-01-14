using Interface;

namespace App.Forms
{
    public partial class Detail : Form, IDetailView
    {
        public BindingSource BindingSource { get; set; }

        public Detail()
        {
            InitializeComponent();
            BindingSource = schuelerBindingSource;
        }



        public void ShowDetail()
        {
            this.ShowDialog();
        }


    }
}
