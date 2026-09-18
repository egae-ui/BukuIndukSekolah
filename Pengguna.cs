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
    public partial class Pengguna : Form
    {
        public Pengguna()
        {
            InitializeComponent();
            tampildata();
            BtnTambah.Select();
        }

        private string Idu_pilih = null;

        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            DBBIS.crud("Select * From user");
            int no = 1;
            foreach (DataRow brs in DBBIS.ds.Tables[0].Rows)
            {
                string User = "" + brs["Username"];
                string Role = "" + brs["Role"];
                string Idu = "" + brs["Idu"];
                guna2DataGridView1.Rows.Add(no, User, Role,Idu);
                no++;
            }
        }

        private void bersih()
        {
            TxtUser.Text = "";
            TxtPass.Text = "";
            CmbRole.SelectedIndex = -1;
            Idu_pilih = null;
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            PnlCrud.Visible = true;
            TxtUser.Select();
            bersih();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            DBBIS.crud($"Select * From user WHERE Username like '%{TxtSearch.Text}%'");
            foreach (DataRow brs in DBBIS.ds.Tables[0].Rows)
            {
                string User = "" + brs["Username"];
                string Role = "" + brs["Role"];
                guna2DataGridView1.Rows.Add(User, Role);
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            string User = TxtUser.Text;
            string Pass = TxtPass.Text;
            string Role = CmbRole.Text;

            if (User == "" || Pass == "" || CmbRole.SelectedIndex == -1)

            {
                MessageBox.Show("Lengkapi Data");
            }
            if (Idu_pilih == null)
            {
                DBBIS.crud($"INSERT INTO user VALUES (null, '{User}', MD5('{Pass}'),'{Role}')");
            }

            else
            {
                DBBIS.crud($"UPDATE `user` SET Username = '{User}', `Password` = MD5('{Pass}'), Role = '{Role}' WHERE `Idu` = '{Idu_pilih}'");
            }
            bersih();
            PnlCrud.Visible = false;
            tampildata();
        }
       
        private void CmbRole_DropDown(object sender, EventArgs e)
        {
            CmbRole.DataSource = null;
            DBBIS.crud("SELECT `Role` FROM `role`");
            CmbRole.DataSource = DBBIS.ds.Tables[0];
            CmbRole.DisplayMember = "Role";
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;
            if (column == 4)
            {
                PnlCrud.Visible = true;
                Idu_pilih = guna2DataGridView1.Rows[row].Cells[3].Value.ToString();
                TxtUser.Text = guna2DataGridView1.Rows[row].Cells[1].Value.ToString();
                CmbRole.Text = guna2DataGridView1.Rows[row].Cells[2].Value.ToString();
                TxtPass.Text = "";

            }

            if (column == 5)
            {
                Idu_pilih = guna2DataGridView1.Rows[row].Cells[3].Value.ToString();
                DialogResult setuju = MessageBox.Show("Apakah mau hapus? " + Idu_pilih, "pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    DBBIS.crud($"DELETE FROM user WHERE Idu = '{Idu_pilih}'");
                }
                tampildata();
            }
        }

        private void BtnBatal_Click_1(object sender, EventArgs e)
        {
            PnlCrud.Visible = false;
            bersih();
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
                if (TxtPass.Text != "")
                {
                    CmbRole.Select();
                }
            }
        }

        private void CmbRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (CmbRole.Text != "")
                {
                    BtnSimpan.Select();
                }
            }
        }
    }
}