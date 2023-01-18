using System.Windows.Forms;

namespace Interface
{
    public interface IDetailView
    {
        public BindingSource SchuelerBindingSource { get; set; }
        public BindingSource AdresseBindingSource { get; set; }
        public BindingSource AntragBinDingSource { get; set; }
        public BindingSource GenehmigtStatus { get; set; }

        public void ShowDetail();
    }
}
