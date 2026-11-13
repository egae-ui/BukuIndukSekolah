using System;
using System.Data;
using System.Windows.Forms;

namespace BukuIndukSekolah
{
    public partial class WaliKelas : Form
    {
        public WaliKelas()
        {
            InitializeComponent();
            tampildata();
            BtnTambah.Select();
        }

        private string IdW_pilih = null;

        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            // Tampilkan data kelas beserta wali kelas (dari tabel user role Guru)
            DBBIS.crud(@"SELECT k.id_kelas, k.nama_kelas, j.nama_jurusan, 
                         COALESCE(u.Username, '-') AS wali_kelas, k.tahun_ajaran
                         FROM kelas k 
                         LEFT JOIN jurusan j ON k.id_jurusan = j.id_jurusan
                         LEFT JOIN user u ON k.id_guru = u.Idu
                         ORDER BY k.id_kelas");
            int no = 1;
            foreach (DataRow brs in DBBIS.ds.Tables[0].Rows)
            {
                guna2DataGridView1.Rows.Add(no,
                    "" + brs["nama_kelas"],
                    "" + brs["nama_jurusan"],
                    "" + brs["wali_kelas"],
                    "" + brs["tahun_ajaran"],
                    "" + brs["id_kelas"]);
                no++;
            }
        }

        private void bersih()
        {
            CmbKelas.SelectedIndex   = -1;
            CmbGuru.SelectedIndex    = -1;
            TxtTahunAjaran.Text      = "";
            IdW_pilih = null;
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            bersih();
            PnlCrud.Visible = true;
            CmbKelas.Select();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            DBBIS.crud($@"SELECT k.id_kelas, k.nama_kelas, j.nama_jurusan,
                          COALESCE(u.Username, '-') AS wali_kelas, k.tahun_ajaran
                          FROM kelas k 
                          LEFT JOIN jurusan j ON k.id_jurusan = j.id_jurusan
                          LEFT JOIN user u ON k.id_guru = u.Idu
                          WHERE k.nama_kelas LIKE '%{TxtSearch.Text}%'
                          ORDER BY k.id_kelas");
            int no = 1;
            foreach (DataRow brs in DBBIS.ds.Tables[0].Rows)
            {
                guna2DataGridView1.Rows.Add(no,
                    "" + brs["nama_kelas"],
                    "" + brs["nama_jurusan"],
                    "" + brs["wali_kelas"],
                    "" + brs["tahun_ajaran"],
                    "" + brs["id_kelas"]);
                no++;
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (CmbKelas.SelectedIndex == -1 || CmbGuru.SelectedIndex == -1)
            {
                MessageBox.Show("Kelas dan Wali Kelas wajib dipilih!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ambil id_kelas
            string namaKelas = CmbKelas.Text;
            DBBIS.crud($"SELECT id_kelas FROM kelas WHERE nama_kelas = '{namaKelas}'");
            if (DBBIS.ds.Tables[0].Rows.Count == 0) return;
            string idKelas = "" + DBBIS.ds.Tables[0].Rows[0]["id_kelas"];

            // Ambil id guru
            string namaGuru = CmbGuru.Text;
            DBBIS.crud($"SELECT Idu FROM user WHERE Username = '{namaGuru}'");
            if (DBBIS.ds.Tables[0].Rows.Count == 0) return;
            string idGuru = "" + DBBIS.ds.Tables[0].Rows[0]["Idu"];

            string tahun = TxtTahunAjaran.Text.Trim();
            if (string.IsNullOrEmpty(tahun)) tahun = "0000";

            DBBIS.crud($"UPDATE kelas SET id_guru='{idGuru}', tahun_ajaran='{tahun}' WHERE id_kelas='{idKelas}'");
            MessageBox.Show("Wali Kelas berhasil disimpan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bersih();
            PnlCrud.Visible = false;
            tampildata();
        }

        private void BtnBatal_Click(object sender, EventArgs e)
        {
            PnlCrud.Visible = false;
            bersih();
        }

        private void CmbKelas_DropDown(object sender, EventArgs e)
        {
            CmbKelas.DataSource = null;
            DBBIS.crud("SELECT nama_kelas FROM kelas ORDER BY id_kelas");
            CmbKelas.DataSource = DBBIS.ds.Tables[0];
            CmbKelas.DisplayMember = "nama_kelas";
        }

        private void CmbGuru_DropDown(object sender, EventArgs e)
        {
            CmbGuru.DataSource = null;
            DBBIS.crud("SELECT Username FROM user WHERE Role='Guru' OR Role='Guru-Honorer'");
            CmbGuru.DataSource = DBBIS.ds.Tables[0];
            CmbGuru.DisplayMember = "Username";
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            if (row < 0) return;

            string idK = guna2DataGridView1.Rows[row].Cells[5].Value?.ToString();

            if (col == 6) // Edit
            {
                IdW_pilih = idK;
                DBBIS.crud($"SELECT k.*, u.Username FROM kelas k LEFT JOIN user u ON k.id_guru=u.Idu WHERE k.id_kelas='{idK}'");
                if (DBBIS.ds.Tables[0].Rows.Count > 0)
                {
                    DataRow brs = DBBIS.ds.Tables[0].Rows[0];

                    DBBIS.crud("SELECT nama_kelas FROM kelas ORDER BY id_kelas");
                    CmbKelas.DataSource = DBBIS.ds.Tables[0];
                    CmbKelas.DisplayMember = "nama_kelas";
                    CmbKelas.Text = "" + brs["nama_kelas"];

                    DBBIS.crud("SELECT Username FROM user WHERE Role='Guru' OR Role='Guru-Honorer'");
                    CmbGuru.DataSource = DBBIS.ds.Tables[0];
                    CmbGuru.DisplayMember = "Username";
                    CmbGuru.Text = "" + brs["Username"];

                    TxtTahunAjaran.Text = "" + brs["tahun_ajaran"];
                }
                PnlCrud.Visible = true;
            }
            else if (col == 7) // Hapus (reset wali kelas)
            {
                DialogResult setuju = MessageBox.Show("Reset wali kelas ini?", "Konfirmasi",
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    DBBIS.crud($"UPDATE kelas SET id_guru=0 WHERE id_kelas='{idK}'");
                    tampildata();
                }
            }
        }
    }
}
