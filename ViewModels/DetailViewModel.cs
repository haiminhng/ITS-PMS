using Interface;

namespace ViewModels
{
    public class DetailViewModel : IDetailView
    {
        public BindingSource AntragBindingSource { get; set; }
        public BindingSource SchuelerBindingSource { get; set; }
        public BindingSource AdresseBindingSource { get; set; }

        void IDetailView.ShowForm(Form form)
        {
            form.ShowDialog();
        }
    }
}
