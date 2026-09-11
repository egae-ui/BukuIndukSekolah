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
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            DBBIS.crud($"SELECT * FROM user WHERE Username = '{TxtUser.Text}' AND Password = MD5('{TxtPass.Text}')");
            int cekbaris = DBBIS.ds.Tables[0].Rows.Count;
            if (cekbaris == 1)
            {
                string role = DBBIS.ds.Tables[0].Rows[0]["Role"].ToString();
                if (role == "Admin")
                {
                    Dashboard Menu = new Dashboard();
                    Menu.Visible = true;
                    this.Hide();
                }
                else if (role == "Guru")
                {
                    DashPetugas Menu = new DashPetugas();
                    Menu.Visible = true;
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Username Atau Password Salah");
            }
            
        }

        private void FLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TxtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TxtUser.Text != "")
                {   
                    TxtPass.Select();
                }
            }
        }

        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TxtUser.Text != "")
                {
                    BtnLogin.Select();
                }
            }
        }
    }    
}


