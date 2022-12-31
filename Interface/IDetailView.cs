using System.Windows.Forms;

namespace Interface
{
    public interface IDetailView
    {
        public BindingSource BindingSource { get; set; }

        public void ShowDetail();
    }
}
