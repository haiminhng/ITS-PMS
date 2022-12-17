using Interface;
using System.Windows.Forms;
using Unity;
namespace App
{
    public partial class Antrag : Form
    {
        private IAntragViewModel _vm = Config.Container.Resolve<IAntragViewModel>();
        private IDetailView _detailView = Config.Container.Resolve<IDetailView>();

        public Antrag()
        {
            InitializeComponent();
            _vm.AntragBindingSource = parkplatzantragBindingSource;
            _vm.SchuelerBindingSource = schuelerBindingSource;
            _vm.AdresseBindingSource = adressenBindingSource;
            _vm.webView = webView21;

            Load += delegate { _vm.LoadAsync(); };

            //Button Control
            btnNew.Click += delegate { _vm.New(); };
            btnSave.Click += delegate { _vm.Save(); };
            btnDelete.Click += delegate { _vm.Delete(); };
            btnFirst.Click += delegate { _vm.First(); };
            btnPrevious.Click += delegate { _vm.Previous(); };
            btnNext.Click += delegate { _vm.Next(); };
            btnLast.Click += delegate { _vm.Last(); };

            //DataGridView Control
            dataGridViewParkingApplication.CellClick += delegate { _vm.DataGridView_CellClick(); };
            dataGridViewParkingApplication.CellFormatting += delegate { _vm.DataGridView_CellFormatting(); };
            dataGridViewParkingApplication.CellDoubleClick += delegate { _vm.DataGridView_CellDoubleClick(_detailView); };

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Get the value to search for from the text box
            
            string searchText = textBox1.Text.ToLower();

            foreach (DataGridViewRow row in dataGridViewParkingApplication.Rows)
            {
                if(row.IsNewRow) continue; // Skip new rows

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