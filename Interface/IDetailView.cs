﻿using System.Windows.Forms;

namespace Interface
{
    public interface IDetailView
    {
        void ShowForm(Form form);
        public BindingSource AntragBindingSource { get; set; }
        public BindingSource SchuelerBindingSource { get; set; }
        public BindingSource AdresseBindingSource { get; set; }
    }
}
