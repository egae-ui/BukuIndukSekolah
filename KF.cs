using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BukuIndukSekolah
{
    class KF
    {
        public static void untukformbis(Form formbis, Panel panelbis)
        {
            panelbis.Controls.Clear();
            formbis.FormBorderStyle = FormBorderStyle.None;
            formbis.Dock = DockStyle.Fill;
            panelbis.Controls.Add(formbis);
            formbis.Show();
        }
    }
}
