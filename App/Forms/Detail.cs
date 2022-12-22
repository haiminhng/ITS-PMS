using Interface;
using Unity;

namespace App.Forms
{
    public partial class Detail : Form
    {
        private IDetailView _detailView = UnityConfig.container.Resolve<IDetailView>();

        public Detail()
        {
            InitializeComponent();
        }

    }
}
