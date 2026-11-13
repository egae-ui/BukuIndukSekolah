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
                string jurusan = "" + brs["nama_jurusan"];
                guna2DataGridView1.Rows.Add(no, jurusan);
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
                string jurusan = "" + brs["nama_jurusan"];
                guna2DataGridView1.Rows.Add(jurusan);
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        { 
            string jurusan = TxtJurusan.Text;
            if (Idj_pilih == null)
            {
                DBBIS.crud($"INSERT INTO jurusan VALUES (null, '{jurusan}')");
            }

            else
            {
                DBBIS.crud($"UPDATE `jurusan` SET nama_jurusan = '{jurusan}' WHERE `id_jurusan` = '{Idj_pilih}'");
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
                // Cells[0] = nomor urut, ambil id_jurusan dari DB berdasarkan nama di Cells[1]
                Idj_pilih = guna2DataGridView1.Rows[row].Cells[0].Value.ToString();
                TxtJurusan.Text = guna2DataGridView1.Rows[row].Cells[1].Value.ToString();

                // Ambil id_jurusan yang benar berdasarkan nama
                DBBIS.crud($"SELECT id_jurusan FROM jurusan WHERE nama_jurusan = '{TxtJurusan.Text}'");
                if (DBBIS.ds.Tables[0].Rows.Count > 0)
                    Idj_pilih = "" + DBBIS.ds.Tables[0].Rows[0]["id_jurusan"];
            }

            if (column == 3)
            {
                string namaJurusan = guna2DataGridView1.Rows[row].Cells[1].Value.ToString();

                // Ambil id_jurusan dari DB berdasarkan nama
                DBBIS.crud($"SELECT id_jurusan FROM jurusan WHERE nama_jurusan = '{namaJurusan}'");
                if (DBBIS.ds.Tables[0].Rows.Count > 0)
                {
                    Idj_pilih = "" + DBBIS.ds.Tables[0].Rows[0]["id_jurusan"];
                    DialogResult setuju = MessageBox.Show("Apakah mau hapus jurusan: " + namaJurusan + "?",
                                                          "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (setuju == DialogResult.Yes)
                    {
                        DBBIS.crud($"DELETE FROM jurusan WHERE id_jurusan = '{Idj_pilih}'");
                    }
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
