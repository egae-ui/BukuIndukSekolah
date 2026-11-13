using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BukuIndukSekolah
{
    public partial class LaporanSiswa : Form
    {
        private DataTable _dtLaporan = new DataTable();
        private PrintDocument _printDoc;
        private int _halCetak = 0;
        private int _barisCetak = 0;

        public LaporanSiswa()
        {
            InitializeComponent();
        }

        private void LaporanSiswa_Load(object sender, EventArgs e)
        {
            // Isi dropdown jurusan
            CmbFilterJurusan.Items.Clear();
            CmbFilterJurusan.Items.Add("-- Semua Jurusan --");
            DBBIS.crud("SELECT nama_jurusan FROM jurusan ORDER BY nama_jurusan");
            foreach (DataRow r in DBBIS.ds.Tables[0].Rows)
                CmbFilterJurusan.Items.Add(r["nama_jurusan"].ToString());
            CmbFilterJurusan.SelectedIndex = 0;

            // Isi dropdown kelas
            CmbFilterKelas.Items.Clear();
            CmbFilterKelas.Items.Add("-- Semua Kelas --");
            DBBIS.crud("SELECT nama_kelas FROM kelas ORDER BY nama_kelas");
            foreach (DataRow r in DBBIS.ds.Tables[0].Rows)
                CmbFilterKelas.Items.Add(r["nama_kelas"].ToString());
            CmbFilterKelas.SelectedIndex = 0;

            MuatData("1=1");
        }

        // ─── Ambil data dari DB dan tampilkan di grid ───────────────
        private void MuatData(string kondisi)
        {
            try
            {
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

                // Tampilkan di DataGridView
                dgvLaporan.DataSource = null;
                dgvLaporan.Rows.Clear();
                dgvLaporan.Columns.Clear();

                string[] headers = { "No", "NIPD", "NISN", "Nama Lengkap", "Jurusan",
                                     "Kelas", "L/P", "Tempat, Tgl Lahir", "Agama",
                                     "Nama Ayah", "Nama Ibu", "Alamat" };
                int[]    widths  = { 40, 80, 100, 180, 220, 100, 50, 160, 70, 120, 120, 200 };

                for (int i = 0; i < headers.Length; i++)
                {
                    var col = new DataGridViewTextBoxColumn();
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

        // ─── PRINT menggunakan PrintDocument (tanpa Crystal Reports) ─
        private void CetakLaporan()
        {
            _halCetak   = 0;
            _barisCetak = 0;

            _printDoc = new PrintDocument();
            _printDoc.DefaultPageSettings.Landscape = true;
            // A4 landscape: 297mm x 210mm = 1169 x 827 dalam 1/100 inch
            _printDoc.DefaultPageSettings.PaperSize = new PaperSize("A4", 1169, 827);
            _printDoc.DefaultPageSettings.Margins   = new Margins(40, 40, 40, 40);
            _printDoc.PrintPage += PrintDoc_PrintPage;

            using (var preview = new PrintPreviewDialog())
            {
                preview.Document    = _printDoc;
                preview.WindowState = FormWindowState.Maximized;
                preview.ShowDialog();
            }
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            // Gunakan MarginBounds agar koordinat konsisten dengan margin yang ditetapkan
            float left   = e.MarginBounds.Left;
            float top    = e.MarginBounds.Top;
            float right  = e.MarginBounds.Right;
            float width  = e.MarginBounds.Width;
            float bottom = e.MarginBounds.Bottom;
            float y      = top;

            Font  fontJudul  = new Font("Arial", 14, FontStyle.Bold);
            Font  fontSub    = new Font("Arial", 9,  FontStyle.Italic);
            Font  fontHeader = new Font("Arial", 8,  FontStyle.Bold);
            Font  fontData   = new Font("Arial", 7.5f);
            Brush brBlack    = Brushes.Black;
            Brush brHeader   = new SolidBrush(Color.Teal);
            Brush brWhite    = Brushes.White;
            StringFormat sfLeft   = new StringFormat { Alignment = StringAlignment.Near,   LineAlignment = StringAlignment.Center };
            StringFormat sfCenter = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            StringFormat sfRight  = new StringFormat { Alignment = StringAlignment.Far,    LineAlignment = StringAlignment.Center };

            // ── Header dokumen (hanya halaman pertama) ──────────────
            if (_halCetak == 0)
            {
                g.DrawString("DAFTAR DATA SISWA",
                             fontJudul, brBlack,
                             new RectangleF(left, y, width, 28), sfCenter);
                y += 28;
                g.DrawString("Buku Induk Sekolah  |  Dicetak: " + DateTime.Now.ToString("dd MMMM yyyy"),
                             fontSub, brBlack,
                             new RectangleF(left, y, width, 18), sfCenter);
                y += 18;
                g.DrawLine(new Pen(Color.Teal, 1.5f), left, y, right, y);
                y += 6;
            }

            // ── Definisi kolom (proporsi, bukan piksel kaku) ─────────
            // Total proporsi = 1000 → dibagi ke lebar MarginBounds
            float[] prop  = { 35, 70, 90, 160, 170, 80, 40, 130, 60, 95, 95, 175 };
            string[] colH = { "No", "NIPD", "NISN", "Nama Lengkap", "Jurusan",
                               "Kelas", "L/P", "Tempat, Tgl Lahir", "Agama",
                               "Nama Ayah", "Nama Ibu", "Alamat" };
            float totalProp = 0;
            foreach (var p in prop) totalProp += p;
            float[] colW = new float[prop.Length];
            for (int i = 0; i < prop.Length; i++)
                colW[i] = (prop[i] / totalProp) * width;

            // ── Header tabel (setiap halaman) ───────────────────────
            float rowH = 20f;
            float x    = left;
            for (int i = 0; i < colW.Length; i++)
            {
                g.FillRectangle(brHeader, x, y, colW[i], rowH);
                g.DrawRectangle(Pens.White, x, y, colW[i], rowH);
                g.DrawString(colH[i], fontHeader, brWhite,
                             new RectangleF(x + 2, y, colW[i] - 4, rowH), sfCenter);
                x += colW[i];
            }
            y += rowH;

            // ── Baris data ──────────────────────────────────────────
            bool adaLagi = false;
            while (_barisCetak < _dtLaporan.Rows.Count)
            {
                // Hitung tinggi baris dinamis (khusus kolom Nama & Alamat yang bisa wrap)
                DataRow dr = _dtLaporan.Rows[_barisCetak];
                string  valNama   = dr["nama_lengkap"]?.ToString() ?? "";
                string  valAlamat = dr["alamat_domisili"]?.ToString() ?? "";
                // Ukur tinggi text untuk kolom paling panjang
                SizeF szNama   = g.MeasureString(valNama,   fontData, (int)colW[3]);
                SizeF szAlamat = g.MeasureString(valAlamat, fontData, (int)colW[11]);
                float dynH = Math.Max(rowH, Math.Max(szNama.Height, szAlamat.Height) + 4);

                if (y + dynH > bottom) { adaLagi = true; break; }

                object[] vals = {
                    _barisCetak + 1,
                    dr["nipd"], dr["nisn"], dr["nama_lengkap"],
                    dr["jurusan"], dr["kelas"], dr["jenis_kelamin"],
                    dr["ttl"], dr["agama"],
                    dr["nama_ayah"], dr["nama_ibu"], dr["alamat_domisili"]
                };

                Brush rowBrush = (_barisCetak % 2 == 0)
                                 ? Brushes.White
                                 : new SolidBrush(Color.FromArgb(235, 255, 255));
                x = left;
                for (int i = 0; i < colW.Length; i++)
                {
                    g.FillRectangle(rowBrush, x, y, colW[i], dynH);
                    g.DrawRectangle(Pens.LightGray, x, y, colW[i], dynH);
                    StringFormat sf = (i == 0 || i == 6) ? sfCenter : sfLeft;
                    g.DrawString(vals[i]?.ToString() ?? "", fontData, brBlack,
                                 new RectangleF(x + 3, y + 2, colW[i] - 6, dynH - 4), sf);
                    x += colW[i];
                }
                y += dynH;
                _barisCetak++;
            }

            // ── Garis penutup tabel ──────────────────────────────────
            g.DrawLine(new Pen(Color.Teal, 1f), left, y, right, y);

            // ── Footer halaman ───────────────────────────────────────
            _halCetak++;
            g.DrawString($"Halaman {_halCetak}  —  Total {_dtLaporan.Rows.Count} siswa",
                         fontSub, brBlack,
                         new RectangleF(left, bottom + 5, width, 20), sfRight);

            e.HasMorePages = adaLagi;

            // Dispose font & brush yang dibuat manual
            fontJudul.Dispose(); fontSub.Dispose(); fontHeader.Dispose(); fontData.Dispose();
            brHeader.Dispose();
        }

        // ─── Event handlers ─────────────────────────────────────────

        private void BtnTampil_Click(object sender, EventArgs e)
        {
            string kondisi = "1=1";
            if (CmbFilterJurusan.SelectedIndex > 0)
                kondisi += $" AND jurusan = '{CmbFilterJurusan.Text}'";
            if (CmbFilterKelas.SelectedIndex > 0)
                kondisi += $" AND kelas = '{CmbFilterKelas.Text}'";
            MuatData(kondisi);
        }

        private void BtnCetak_Click(object sender, EventArgs e)
        {
            if (_dtLaporan.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk dicetak.", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            CetakLaporan();
        }

        private void CmbFilterJurusan_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbFilterKelas.Items.Clear();
            CmbFilterKelas.Items.Add("-- Semua Kelas --");

            if (CmbFilterJurusan.SelectedIndex > 0)
            {
                // Cari id_jurusan berdasarkan nama, lalu filter kelas secara dinamis
                DBBIS.crud($"SELECT id_jurusan FROM jurusan WHERE nama_jurusan = '{CmbFilterJurusan.Text}'");
                if (DBBIS.ds.Tables[0].Rows.Count > 0)
                {
                    string idJ = "" + DBBIS.ds.Tables[0].Rows[0]["id_jurusan"];
                    DBBIS.crud($"SELECT nama_kelas FROM kelas WHERE id_jurusan = '{idJ}' ORDER BY nama_kelas");
                    foreach (DataRow r in DBBIS.ds.Tables[0].Rows)
                        CmbFilterKelas.Items.Add(r["nama_kelas"].ToString());
                }
            }

            CmbFilterKelas.SelectedIndex = 0;
        }
    }
}