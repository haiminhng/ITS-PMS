using Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Forms
{
    public partial class FileLoadingForm : Form, IFileLoadingForm
    {
        public event EventHandler LoadFileClicked;

        public FileLoadingForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
        }

        public void SetProgress(double value)
        {
            progressBar1.Value = (int)value;
        }

        public void SetStatus(string status)
        {
            statusLabel.Text = status;
        }

        public void Show()
        {
            base.Show();
            //Application.Run(this);
        }

        public void Close()
        {
            base.Close();
            //Application.ExitThread();
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            LoadFileClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
