using Interface;
using Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using ViewModels;
namespace App
{
    public partial class Antrag : Form
    {
        private IAntragViewModel _vm = Config.Container.Resolve<IAntragViewModel>();

        public Antrag()
        {
            InitializeComponent();

            _vm.AntragBindingSource = parkplatzantragBindingSource;
            _vm.SchuelerBindingSource = schuelerBindingSource;
            _vm.AdresseBindingSource = adressenBindingSource;

            Load += delegate { _vm.LoadAsync( ); };

            //Button Control
            btnNew.Click += delegate { _vm.New(); };
            btnSave.Click += delegate { _vm.Save(webView21); };
            btnDelete.Click += delegate { _vm.Delete(); };
            btnFirst.Click += delegate { _vm.First(); };
            btnPrevious.Click += delegate { _vm.Previous(); };
            btnNext.Click += delegate { _vm.Next(); };
            btnLast.Click += delegate { _vm.Last(); };
            dataGridViewParkingApplication.CellClick += delegate { _vm.DataGridClick(webView21); };

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}