using App.Forms;
using Interface;
using System.CodeDom;
using System.Data;
using System.Windows.Forms;
using Unity;
namespace App
{
    public partial class Antrag : Form
    {
        private IAntragViewModel _vm = UnityConfig.container.Resolve<IAntragViewModel>();
        
        public Antrag()
        {
            InitializeComponent();
            _vm.webView = webView21;
            _vm.searchBox = tbSearch;
            _vm.parkPlatzAntragView = dataGridViewParkingApplication;
            _vm.AntragBindingSource = parkplatzantragBindingSource;
            _vm.SchuelerBindingSource = schuelerBindingSource;
            _vm.AdresseBindingSource = adressenBindingSource;
            _vm.GenehmigtStatus = genehmigtstatusBindingSource;


            Load += delegate { _vm.LoadAsync(); };

            //Button Control
            btnEmail.Click += delegate { _vm.ShowMailSender(UnityConfig.container.Resolve<IMailSender>()); ;};
            btnNew.Click += delegate { _vm.New(); };
            btnSave.Click += delegate { _vm.Save(); };
            btnDelete.Click += delegate { _vm.Delete(); };
            btnNewCalc.Click += delegate { _vm.CalcNewRouteData(); };
            btnFirst.Click += delegate { _vm.First(); };
            btnPrevious.Click += delegate { _vm.Previous(); };
            btnNext.Click += delegate { _vm.Next(); };
            btnLast.Click += delegate { _vm.Last(); };

            //Textbox Control
            tbSearch.TextChanged += delegate { _vm.Search(); };

            //DataGridView Control
            dataGridViewParkingApplication.CellClick += delegate { _vm.DataGridView_CellClick(); };
            dataGridViewParkingApplication.CellFormatting += delegate { _vm.DataGridView_CellFormatting(); };
            dataGridViewParkingApplication.CellDoubleClick += delegate { _vm.ShowDetail(UnityConfig.container.Resolve<IDetailView>()); };
                        
            //ToolStripMenu Control
            mailServerToolStripMenuItem.Click += delegate { _vm.ShowEmailSetting(UnityConfig.container.Resolve<IEmailSetting>()); ; };

        }
    }
}