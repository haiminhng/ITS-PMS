using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public interface IAntragViewModel
    {
        public BindingSource AntragBindingSource { get; set; }
        public BindingSource SchuelerBindingSource { get; set; }
        public BindingSource AdresseBindingSource { get; set; }


        void Delete();
        void First();
        void Last();
        Task LoadAsync( );
        void New();
        void Next();
        void Previous();
        void Save();
        void DataGridClick( );
    }
}
