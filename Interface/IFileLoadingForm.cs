using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public interface IFileLoadingForm
    {
        event EventHandler LoadFileClicked;
        void Show();
        void Close();
        void SetProgress(double value);
        void SetStatus(string status);
    }

}
