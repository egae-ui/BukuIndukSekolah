using System;
using System.Data;
using System.Windows.Forms;

namespace BukuIndukSekolah
{
    public partial class Kelas : Form
    {
        public Kelas()
        {
            InitializeComponent();
            tampildata();
            BtnTambah.Select();
        }

        private string IdK_pilih = null;

        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            DBBIS.crud("SELECT k.id_kelas, k.nama_kelas, j.nama_jurusan, k.tahun_ajaran FROM kelas k LEFT JOIN jurusan j ON k.id_jurusan = j.id_jurusan ORDER BY k.id_kelas");
            int no = 1;
            foreach (DataRow brs in DBBIS.ds.Tables[0].Rows)
            {
                string idK     = "" + brs["id_kelas"];
                string namaK   = "" + brs["nama_kelas"];
                string namaJ   = "" + brs["nama_jurusan"];
                string tahun   = "" + brs["tahun_ajaran"];
                guna2DataGridView1.Rows.Add(no, namaK, namaJ, tahun, idK);
                no++;
            }
        }

        private void bersih()
        {
            TxtNamaKelas.Text = "";
            CmbJurusan.SelectedIndex = -1;
            TxtTahunAjaran.Text = "";
            IdK_pilih = null;
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            bersih();
            PnlCrud.Visible = true;
            TxtNamaKelas.Select();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            DBBIS.crud($"SELECT k.id_kelas, k.nama_kelas, j.nama_jurusan, k.tahun_ajaran FROM kelas k LEFT JOIN jurusan j ON k.id_jurusan = j.id_jurusan WHERE k.nama_kelas LIKE '%{TxtSearch.Text}%' ORDER BY k.id_kelas");
            int no = 1;
            foreach (DataRow brs in DBBIS.ds.Tables[0].Rows)
            {
                guna2DataGridView1.Rows.Add(no,
                    "" + brs["nama_kelas"],
                    "" + brs["nama_jurusan"],
                    "" + brs["tahun_ajaran"],
                    "" + brs["id_kelas"]);
                no++;
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            string namaKelas  = TxtNamaKelas.Text.Trim();
            string tahunAjaran = TxtTahunAjaran.Text.Trim();
            string namaJurusan = CmbJurusan.Text;

            if (namaKelas == "" || CmbJurusan.SelectedIndex == -1)
            {
                MessageBox.Show("Nama Kelas dan Jurusan wajib diisi!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ambil id_jurusan
            DBBIS.crud($"SELECT id_jurusan FROM jurusan WHERE nama_jurusan = '{namaJurusan}'");
            if (DBBIS.ds.Tables[0].Rows.Count == 0) return;
            string idJurusan = "" + DBBIS.ds.Tables[0].Rows[0]["id_jurusan"];

            if (string.IsNullOrEmpty(tahunAjaran)) tahunAjaran = "0000";

            if (IdK_pilih == null)
                DBBIS.crud($"INSERT INTO kelas (nama_kelas, id_jurusan, id_guru, tahun_ajaran) VALUES ('{namaKelas}', '{idJurusan}', 0, '{tahunAjaran}')");
            else
                DBBIS.crud($"UPDATE kelas SET nama_kelas='{namaKelas}', id_jurusan='{idJurusan}', tahun_ajaran='{tahunAjaran}' WHERE id_kelas='{IdK_pilih}'");

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

        private void CmbJurusan_DropDown(object sender, EventArgs e)
        {
            CmbJurusan.DataSource = null;
            DBBIS.crud("SELECT nama_jurusan FROM jurusan");
            CmbJurusan.DataSource = DBBIS.ds.Tables[0];
            CmbJurusan.DisplayMember = "nama_jurusan";
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            if (row < 0) return;

            string idK = guna2DataGridView1.Rows[row].Cells[4].Value?.ToString();

            if (col == 5) // Edit
            {
                IdK_pilih = idK;
                DBBIS.crud($"SELECT k.*, j.nama_jurusan FROM kelas k LEFT JOIN jurusan j ON k.id_jurusan = j.id_jurusan WHERE k.id_kelas = '{idK}'");
                if (DBBIS.ds.Tables[0].Rows.Count > 0)
                {
                    DataRow brs = DBBIS.ds.Tables[0].Rows[0];
                    TxtNamaKelas.Text   = "" + brs["nama_kelas"];
                    TxtTahunAjaran.Text = "" + brs["tahun_ajaran"];

                    // Isi dropdown jurusan dulu
                    DBBIS.crud("SELECT nama_jurusan FROM jurusan");
                    CmbJurusan.DataSource = DBBIS.ds.Tables[0];
                    CmbJurusan.DisplayMember = "nama_jurusan";
                    CmbJurusan.Text = "" + brs["nama_jurusan"];
                }
                PnlCrud.Visible = true;
            }
            else if (col == 6) // Hapus
            {
                DialogResult setuju = MessageBox.Show($"Hapus kelas ini?", "Konfirmasi",
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    DBBIS.crud($"DELETE FROM kelas WHERE id_kelas = '{idK}'");
                    tampildata();
                }
            }
        }
    }
}
