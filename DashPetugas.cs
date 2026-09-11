using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BukuIndukSekolah
{
    public partial class DashPetugas : Form
    {
        public DashPetugas()
        {
            InitializeComponent();

        }

        private void BtnDataM_Click(object sender, EventArgs e)
        {
            if (FPnlDataM.Visible == false)
            {
                FPnlDataM.Visible = true;
            }
            else
            {
                FPnlDataM.Visible = false;
            }
        }

        private void LabelBar_Click(object sender, EventArgs e)
        {
            if (PnlSidebar.Visible == true)
            {
                PnlSidebar.Visible = false;
            }
            else
            {
                PnlSidebar.Visible = true;
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            {
                DialogResult setuju = MessageBox.Show("Apakah mau LogOut?", "pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (setuju == DialogResult.Yes)
                {
                    FLogin F1 = new FLogin();
                    F1.Visible = true;
                    this.Hide();
                }
            }
        }

        private void BtnPengguna_Click(object sender, EventArgs e)
        {
            Pengguna Menu = new Pengguna() { TopMost = true, TopLevel = false };
            KF.untukformbis(Menu, PnlContent);
        }

        private void BtnRole_Click(object sender, EventArgs e)
        {
            Role Menu = new Role() { TopMost = true, TopLevel = false };
            KF.untukformbis(Menu, PnlContent);
        }
    }
}
