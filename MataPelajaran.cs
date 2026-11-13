using System;
using System.Data;
using System.Windows.Forms;

namespace BukuIndukSekolah
{
    public partial class MataPelajaran : Form
    {
        public MataPelajaran()
        {
            InitializeComponent();
            BuatTabelJikaBelumAda();
            tampildata();
            BtnTambah.Select();
        }

        private string IdMP_pilih = null;

        private void BuatTabelJikaBelumAda()
        {
            try
            {
                DBBIS.crud(@"CREATE TABLE IF NOT EXISTS mata_pelajaran (
                    id_mapel INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
                    nama_mapel VARCHAR(100) NOT NULL,
                    kode_mapel VARCHAR(20) NOT NULL,
                    keterangan VARCHAR(200)
                ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4");
            }
            catch { /* Tabel sudah ada */ }
        }

        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            DBBIS.crud("SELECT id_mapel, kode_mapel, nama_mapel, keterangan FROM mata_pelajaran ORDER BY id_mapel");
            int no = 1;
            foreach (DataRow brs in DBBIS.ds.Tables[0].Rows)
            {
                guna2DataGridView1.Rows.Add(no,
                    "" + brs["kode_mapel"],
                    "" + brs["nama_mapel"],
                    "" + brs["keterangan"],
                    "" + brs["id_mapel"]);
                no++;
            }
        }

        private void bersih()
        {
            TxtKode.Text = "";
            TxtNamaMapel.Text = "";
            TxtKeterangan.Text = "";
            IdMP_pilih = null;
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            bersih();
            PnlCrud.Visible = true;
            TxtKode.Select();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            DBBIS.crud($"SELECT id_mapel, kode_mapel, nama_mapel, keterangan FROM mata_pelajaran WHERE nama_mapel LIKE '%{TxtSearch.Text}%' OR kode_mapel LIKE '%{TxtSearch.Text}%' ORDER BY id_mapel");
            int no = 1;
            foreach (DataRow brs in DBBIS.ds.Tables[0].Rows)
            {
                guna2DataGridView1.Rows.Add(no,
                    "" + brs["kode_mapel"],
                    "" + brs["nama_mapel"],
                    "" + brs["keterangan"],
                    "" + brs["id_mapel"]);
                no++;
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            string kode = TxtKode.Text.Trim();
            string nama = TxtNamaMapel.Text.Trim();
            string ket  = TxtKeterangan.Text.Trim();

            if (kode == "" || nama == "")
            {
                MessageBox.Show("Kode dan Nama Mata Pelajaran wajib diisi!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IdMP_pilih == null)
                DBBIS.crud($"INSERT INTO mata_pelajaran (kode_mapel, nama_mapel, keterangan) VALUES ('{kode}', '{nama}', '{ket}')");
            else
                DBBIS.crud($"UPDATE mata_pelajaran SET kode_mapel='{kode}', nama_mapel='{nama}', keterangan='{ket}' WHERE id_mapel='{IdMP_pilih}'");

            MessageBox.Show("Data berhasil disimpan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bersih();
            PnlCrud.Visible = false;
            tampildata();
        }

        private void BtnBatal_Click(object sender, EventArgs e)
        {
            PnlCrud.Visible = false;
            bersih();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            if (row < 0) return;

            string idMP = guna2DataGridView1.Rows[row].Cells[4].Value?.ToString();

            if (col == 5) // Edit
            {
                IdMP_pilih = idMP;
                DBBIS.crud($"SELECT * FROM mata_pelajaran WHERE id_mapel='{idMP}'");
                if (DBBIS.ds.Tables[0].Rows.Count > 0)
                {
                    DataRow brs = DBBIS.ds.Tables[0].Rows[0];
                    TxtKode.Text        = "" + brs["kode_mapel"];
                    TxtNamaMapel.Text   = "" + brs["nama_mapel"];
                    TxtKeterangan.Text  = "" + brs["keterangan"];
                }
                PnlCrud.Visible = true;
            }
            else if (col == 6) // Hapus
            {
                DialogResult ok = MessageBox.Show("Hapus mata pelajaran ini?", "Konfirmasi",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                {
                    DBBIS.crud($"DELETE FROM mata_pelajaran WHERE id_mapel='{idMP}'");
                    tampildata();
                }
            }
        }
    }
}
