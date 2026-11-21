using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BukuIndukSekolah
{
    public partial class LaporanSiswa : Form
    {
        private DataTable _dtLaporan = new DataTable();
        private string    _kondisiAktif = "1=1";

        public LaporanSiswa()
        {
            InitializeComponent();
        }

        private void LaporanSiswa_Load(object sender, EventArgs e)
        {
            IsiDropdownJurusan();
            IsiDropdownKelas("");
            MuatData("1=1");
        }

        // ─────────────────────────────────────────────────────────────
        private void IsiDropdownJurusan()
        {
            CmbFilterJurusan.Items.Clear();
            CmbFilterJurusan.Items.Add("-- Semua Jurusan --");
            DBBIS.crud("SELECT nama_jurusan FROM jurusan ORDER BY nama_jurusan");
            foreach (DataRow r in DBBIS.ds.Tables[0].Rows)
                CmbFilterJurusan.Items.Add(r["nama_jurusan"].ToString());
            CmbFilterJurusan.SelectedIndex = 0;
        }

        private void IsiDropdownKelas(string idJurusan)
        {
            CmbFilterKelas.Items.Clear();
            CmbFilterKelas.Items.Add("-- Semua Kelas --");

            string sql = string.IsNullOrEmpty(idJurusan)
                ? "SELECT nama_kelas FROM kelas ORDER BY nama_kelas"
                : $"SELECT nama_kelas FROM kelas WHERE id_jurusan='{idJurusan}' ORDER BY nama_kelas";

            DBBIS.crud(sql);
            foreach (DataRow r in DBBIS.ds.Tables[0].Rows)
                CmbFilterKelas.Items.Add(r["nama_kelas"].ToString());
            CmbFilterKelas.SelectedIndex = 0;
        }

        // ─────────────────────────────────────────────────────────────
        private void MuatData(string kondisi)
        {
            try
            {
                _kondisiAktif = kondisi;

                string sql =
                    "SELECT nipd, nisn, nama_lengkap, jurusan, kelas, jenis_kelamin, " +
                    "CONCAT(tmp_lahir, ', ', DATE_FORMAT(tgl_lahir,'%d-%m-%Y')) AS ttl, " +
                    "agama, nama_ayah, nama_ibu, alamat_domisili " +
                    $"FROM siswa WHERE {kondisi} " +
                    "ORDER BY jurusan, kelas, nama_lengkap";

                string connStr = "server=127.0.0.1;database=dbbis;uid=root;password=;";
                var da = new MySqlDataAdapter(sql, connStr);
                _dtLaporan = new DataTable();
                da.Fill(_dtLaporan);

                // ── Tampilkan preview di DataGridView ──
                dgvLaporan.DataSource = null;
                dgvLaporan.Rows.Clear();
                dgvLaporan.Columns.Clear();

                string[] headers = { "No","NIPD","NISN","Nama Lengkap","Jurusan",
                                     "Kelas","L/P","Tempat, Tgl Lahir","Agama",
                                     "Nama Ayah","Nama Ibu","Alamat" };
                int[]    widths  = { 40,80,100,180,220,100,50,160,70,120,120,200 };

                for (int i = 0; i < headers.Length; i++)
                {
                    var col        = new DataGridViewTextBoxColumn();
                    col.HeaderText = headers[i];
                    col.Name       = "col" + i;
                    col.Width      = widths[i];
                    col.ReadOnly   = true;
                    if (i == 3 || i == 11)
                        col.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dgvLaporan.Columns.Add(col);
                }

                int no = 1;
                foreach (DataRow r in _dtLaporan.Rows)
                {
                    dgvLaporan.Rows.Add(
                        no++,
                        r["nipd"], r["nisn"], r["nama_lengkap"],
                        r["jurusan"], r["kelas"], r["jenis_kelamin"],
                        r["ttl"], r["agama"],
                        r["nama_ayah"], r["nama_ibu"], r["alamat_domisili"]);
                }

                LblTotal.Text = $"Total: {_dtLaporan.Rows.Count} siswa";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─────────────────────────────────────────────────────────────
        // Tombol Tampilkan — filter data di grid
        private void BtnTampil_Click(object sender, EventArgs e)
        {
            string kondisi = "1=1";
            if (CmbFilterJurusan.SelectedIndex > 0)
                kondisi += $" AND jurusan = '{CmbFilterJurusan.Text}'";
            if (CmbFilterKelas.SelectedIndex > 0)
                kondisi += $" AND kelas = '{CmbFilterKelas.Text}'";
            MuatData(kondisi);
        }

        // Tombol Cetak — buka Crystal Reports viewer
        private void BtnCetak_Click(object sender, EventArgs e)
        {
            if (_dtLaporan.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk dicetak.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Gunakan kondisi yang sedang aktif
            CrystalHelper.TampilLaporan(_kondisiAktif);
        }

        // Filter kelas saat jurusan berubah
        private void CmbFilterJurusan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbFilterJurusan.SelectedIndex <= 0)
            {
                IsiDropdownKelas("");
                return;
            }

            DBBIS.crud(
                $"SELECT id_jurusan FROM jurusan WHERE nama_jurusan = '{CmbFilterJurusan.Text}'");
            if (DBBIS.ds.Tables[0].Rows.Count > 0)
            {
                string idJ = "" + DBBIS.ds.Tables[0].Rows[0]["id_jurusan"];
                IsiDropdownKelas(idJ);
            }
        }
    }
}
