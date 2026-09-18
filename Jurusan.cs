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
    public partial class Jurusan : Form
    {
        public Jurusan()
        {
            InitializeComponent();
            tampildata();
            BtnTambah.Select();
        }

        private string Idj_pilih = null;

        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            DBBIS.crud("Select * From jurusan");
            int no = 1;
            foreach (DataRow brs in DBBIS.ds.Tables[0].Rows)
            {
                string Jurusan = "" + brs["nama_jurusan"];
                guna2DataGridView1.Rows.Add(no, Jurusan);
                no++;
            }
            
        }
        private void bersih()
        {
            TxtJurusan.Text = "";
            Idj_pilih = null;
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            PnlCrud.Visible = true;
            TxtJurusan.Select();
            bersih();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            DBBIS.crud($"Select * From jurusan WHERE nama_jurusan like '%{TxtSearch.Text}%'");
            foreach (DataRow brs in DBBIS.ds.Tables[0].Rows)
            {
                string Jurusan = "" + brs["nama_jurusan"];
                guna2DataGridView1.Rows.Add(Jurusan);
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            string Jurusan = TxtJurusan.Text;
            if (Idj_pilih == null)
            {
                DBBIS.crud($"INSERT INTO jurusan VALUES (null, '{Jurusan}')");
            }

            else
            {
                DBBIS.crud($"UPDATE `jurusan` SET nama_jurusan = '{Jurusan}'WHERE `Id_jurusan` = '{Idj_pilih}'");
            }
            bersih();
            PnlCrud.Visible = false;
            tampildata();
                
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;
            if (column == 2)
            {
                PnlCrud.Visible = true;
                Idj_pilih = guna2DataGridView1.Rows[row].Cells[0].Value.ToString();
                TxtJurusan.Text = guna2DataGridView1.Rows[row].Cells[1].Value.ToString();
            }

            if (column == 3)
            {
                Idj_pilih = guna2DataGridView1.Rows[row].Cells[1].Value.ToString();
                DialogResult setuju = MessageBox.Show("Apakah mau hapus? " + Idj_pilih, "pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    DBBIS.crud($"DELETE FROM Jurusan WHERE Id_jurusan = '{Idj_pilih}'");
                }
                tampildata();

            }
        }

        private void BtnBatal_Click(object sender, EventArgs e)
        {
            PnlCrud.Visible = false;
            bersih();
        }
    }
}
