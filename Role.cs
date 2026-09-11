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
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
            tampildata();
            BtnTambah.Select();
        }

        private string Idr_pilih = null;

        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            DBBIS.crud("Select * From role");
            int no = 1;
            foreach (DataRow brs in DBBIS.ds.Tables[0].Rows)
            {
                string Idr = "" + brs["Idr"];
                string Role = "" + brs["Role"];
                string Ket = "" + brs["Keterangan"];
                guna2DataGridView1.Rows.Add(no,Idr, Role, Ket);
                no++;
            }
            
        }
        private void bersih()
        {
            TxtRole.Text = "";
            TxtKeterangan.Text = "";
            Idr_pilih = null;
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            PnlCrud.Visible = true;
            TxtRole.Select();
            bersih();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            DBBIS.crud($"Select * From role WHERE Role like '%{TxtSearch.Text}%'");
            foreach (DataRow brs in DBBIS.ds.Tables[0].Rows)
            {
                string Role = "" + brs["Role"];
                string Ket = "" + brs["Keterangan"];
                guna2DataGridView1.Rows.Add(Role, Ket);
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            string Role = TxtRole.Text;
            string Ket = TxtKeterangan.Text;
            if (Idr_pilih == null)
            {
                DBBIS.crud($"INSERT INTO role VALUES (null, '{Role}','{Ket}')");
            }

            else
            {
                DBBIS.crud($"UPDATE `role` SET Role = '{Role}', Keterangan = '{Ket}' WHERE `Idr` = '{Idr_pilih}'");
            }
            bersih();
            PnlCrud.Visible = false;
            tampildata();
                
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;
            if (column == 4)
            {
                PnlCrud.Visible = true;
                Idr_pilih = guna2DataGridView1.Rows[row].Cells[1].Value.ToString();
                TxtRole.Text = guna2DataGridView1.Rows[row].Cells[2].Value.ToString();
                TxtKeterangan.Text = guna2DataGridView1.Rows[row].Cells[3].Value.ToString();
            }

            if (column == 5)
            {
                Idr_pilih = guna2DataGridView1.Rows[row].Cells[1].Value.ToString();
                DialogResult setuju = MessageBox.Show("Apakah mau hapus? " + Idr_pilih, "pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    DBBIS.crud($"DELETE FROM role WHERE Idr = '{Idr_pilih}'");
                }
                tampildata();

            }
        }

        private void BtnBatal_Click(object sender, EventArgs e)
        {
            PnlCrud.Visible = false;
            bersih();
        }

        private void TxtRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TxtRole.Text != "")
                {
                    TxtKeterangan.Select();
                }
            }
        }

        private void TxtKeterangan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TxtKeterangan.Text == "")
                {
                    TxtRole.Select();
                }
            }
        }
    }
}
