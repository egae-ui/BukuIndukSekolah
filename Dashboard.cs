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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
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

        private void BtnKelas_Click(object sender, EventArgs e)
        {
            if (FPnlKelas.Visible == false)
            {
                FPnlKelas.Visible = true;
            }
            else
            {
                FPnlKelas.Visible = false;
            }
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

        private void BtnUser_Click(object sender, EventArgs e)
        {
            Pengguna Menu = new Pengguna() { TopMost = true, TopLevel = false };
            KF.untukformbis(Menu, PnlContent);
        }

        private void BtnRole_Click(object sender, EventArgs e)
        {
            Role Menu = new Role() { TopMost = true, TopLevel = false };
            KF.untukformbis(Menu, PnlContent);
        }

        private void BtnDash_Click(object sender, EventArgs e)
        {
            Dashboard Menu = new Dashboard();
            Menu.Visible = true;
            this.Hide();
        }

        private void BtnSiswa_Click(object sender, EventArgs e)
        {
            Siswa Menu = new Siswa() { TopMost = true, TopLevel = false };
            KF.untukformbis(Menu, PnlContent);
        }

        private void BtnJurusan_Click(object sender, EventArgs e)
        {
            Jurusan Menu = new Jurusan() { TopMost = true, TopLevel = false };
            KF.untukformbis(Menu, PnlContent);
        }
    }
}
