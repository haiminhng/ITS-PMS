using App.Forms;
using Interface;
using Unity;
namespace App
{
    public partial class Antrag : Form
    {
        private IAntragViewModel _vm = UnityConfig.container.Resolve<IAntragViewModel>();
        private IDetailView _detailView = UnityConfig.container.Resolve<IDetailView>();
        private IMailSender _mailSenderView = UnityConfig.container.Resolve<IMailSender>();

        private Detail _detailForm = new Detail();
        private MailSender _mailSender = new MailSender();

        public Antrag()
        {
            InitializeComponent();
            _vm.webView = webView21;
            _vm.searchBox = tbSearch;
            _vm.parkPlatzAntragView = dataGridViewParkingApplication;
            _vm.AntragBindingSource = parkplatzantragBindingSource;
            _vm.SchuelerBindingSource = schuelerBindingSource;
            _vm.AdresseBindingSource = adressenBindingSource;

            Load += delegate { _vm.LoadAsync(); };

            //Button Control
            btnEmail.Click += delegate { _mailSenderView.ShowForm(_mailSender); };
            btnNew.Click += delegate { _vm.New(); };
            btnSave.Click += delegate { _vm.Save(); };
            btnDelete.Click += delegate { _vm.Delete(); };
            btnNewCalc.Click += delegate { _vm.CalcNewRouteData(); };
            btnFirst.Click += delegate { _vm.First(); };
            btnPrevious.Click += delegate { _vm.Previous(); };
            btnNext.Click += delegate { _vm.Next(); };
            btnLast.Click += delegate { _vm.Last(); };

            //DataGridView Control
            dataGridViewParkingApplication.CellClick += delegate { _vm.DataGridView_CellClick(); };
            dataGridViewParkingApplication.CellFormatting += delegate { _vm.DataGridView_CellFormatting(); };
            dataGridViewParkingApplication.CellDoubleClick += delegate { _detailView.ShowForm(_detailForm); };
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            // Get the value to search for from the text box

            string searchText = tbSearch.Text.ToLower();

            foreach (DataGridViewRow row in dataGridViewParkingApplication.Rows)
            {
                if (row.IsNewRow) continue; // Skip new rows

                row.Visible = true; // Make the row visible again
                string cellValue = row.Cells[1].Value?.ToString().ToLower() ?? "";
                if (!cellValue.Contains(searchText))
                {
                    dataGridViewParkingApplication.EndEdit(); // Commit any pending changes to the data source
                    int rowIndex = row.Index;
                    CurrencyManager cm = (CurrencyManager)BindingContext[dataGridViewParkingApplication.DataSource];
                    cm.SuspendBinding(); // Suspend updates to the data source
                    dataGridViewParkingApplication.Rows[rowIndex].Visible = false; // Set the row to be invisible
                    cm.ResumeBinding(); // Resume updates to the data source
                }
            }
        }
    }
}