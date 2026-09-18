using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using ExcelDataReader;
using MySql.Data.MySqlClient;

namespace BukuIndukSekolah
{
    public partial class Siswa : Form
    {
        public Siswa()
        {
            InitializeComponent();
            tampildata();
            BtnTambah.Select();
            guna2DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private string Nipd_pilih = null;

        private void OtomatisNIPD()
        {
            
            DBBIS.crud("SELECT MAX(nipd) FROM siswa");
            if (DBBIS.ds.Tables[0].Rows.Count > 0 && DBBIS.ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                long lastNipd = Convert.ToInt64(DBBIS.ds.Tables[0].Rows[0][0]);
                TxtNipd.Text = (lastNipd + 1).ToString();
            }
            else
            {
                TxtNipd.Text = "1999001";
            }
        }

        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            DBBIS.crud("Select * From siswa");
            int no = 1;

            foreach (DataRow brs in DBBIS.ds.Tables[0].Rows)
            {
                String nipd = "" + brs["nipd"];
                string nisn = "" + brs["nisn"];
                string nama = "" + brs["nama_lengkap"];
                string jurusan = "" + brs["jurusan"];
                string kelas = "" + brs["kelas"];
                string gender = "" + brs["jenis_kelamin"];
                string tempat = "" + brs["tmp_lahir"];
                DateTime tgl = Convert.ToDateTime(brs["tgl_lahir"]);
                string tanggal = tgl.ToString("yyyy-MM-dd");
                string agama = "" + brs["agama"];
                string alamat = "" + brs["alamat_domisili"];

                guna2DataGridView1.Rows.Add(no, "Nipd : "+nipd+"\n"+"Nisn : "+ nisn, nama +"\n"+"📌"+ tempat + ", " + tanggal,"Jurusan : "+ jurusan+"\nKelas : "+ kelas, gender, agama, alamat,nipd);
                no++;
            }
        }


        private void bersih()
        {
            TxtNisn.Text = "";
            TxtNipd.Text = "";
            TxtNama.Text = "";
            CmbJurusan.SelectedIndex = -1;
            CmbKelas.SelectedIndex = -1;
            RBLakilaki.Checked = false;
            RBPerempuan.Checked = false;
            DTPTglLahir.Value = DateTime.Now;
            TxtTmpLahir.Text = "";
            CmbAgama.SelectedIndex = -1;
            TxtNmAyah.Text = "";
            TxtNmIbu.Text = "";
            TxtAlamat.Text = "";
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            bersih();
            OtomatisNIPD();
            PnlCrud.Visible = true;
            TxtNisn.Select();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            DBBIS.crud($"SELECT * FROM siswa WHERE nama_lengkap LIKE '%{TxtSearch.Text}%' OR nisn LIKE '%{TxtSearch.Text}%'"); 
            foreach (DataRow brs in DBBIS.ds.Tables[0].Rows)
            {
                tampildata();
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            string nipd = TxtNipd.Text;
            string nisn = TxtNisn.Text;
            string nama = TxtNama.Text;
            string kelas = CmbKelas.Text;
            string jurusan = CmbJurusan.Text;
            string agama = CmbAgama.Text;
            string tempat = TxtTmpLahir.Text;

            string tanggal = DTPTglLahir.Value.ToString("yyyy-MM-dd");

            string ayah = TxtNmAyah.Text;
            string ibu = TxtNmIbu.Text;
            string alamat = TxtAlamat.Text;

            string gender = "";
            if (RBLakilaki.Checked) { gender = "Laki-laki"; }
            else if (RBPerempuan.Checked) { gender = "Perempuan"; }

            if (nipd == "" || nisn == "" || nama == "" || kelas == "" || jurusan == "" || gender == "")
            {
                MessageBox.Show("Lengkapi Data Utama Siswa!");
            }
            else
            {
                if (Nipd_pilih == null)
                {
                    DBBIS.crud($"INSERT INTO siswa VALUES ('{nipd}', '{nisn}', '{jurusan}', '{kelas}', '{nama}', '{gender}', '{tempat}', '{tanggal}', '{agama}', '{ayah}', '{ibu}', '{alamat}')");
                    MessageBox.Show("Data Siswa Berhasil Disimpan!");
                }
                else
                {
                    DBBIS.crud($"UPDATE siswa SET nisn='{nisn}', jurusan='{jurusan}', kelas='{kelas}', nama_lengkap='{nama}', jenis_kelamin='{gender}', tmp_lahir='{tempat}', tgl_lahir='{tanggal}', agama='{agama}', nama_ayah='{ayah}', nama_ibu='{ibu}', alamat_domisili='{alamat}' WHERE nipd='{Nipd_pilih}'");
                    MessageBox.Show("Data Siswa Berhasil Diubah!");
                }
                bersih();
                PnlCrud.Visible = false;
                tampildata();
            }

        }
           

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;

            if (row >= 0)
            {
                string nipd_terpilih = guna2DataGridView1.Rows[row].Cells[7].Value.ToString();

                if (column == 8)
                {
                    PnlCrud.Visible = true;
                    Nipd_pilih = nipd_terpilih;

                    DBBIS.crud($"SELECT * FROM siswa WHERE nipd = '{nipd_terpilih}'");

                    if (DBBIS.ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow brs = DBBIS.ds.Tables[0].Rows[0];

                        CmbJurusan.SelectedIndexChanged -= CmbJurusan_SelectedIndexChanged;
 
                        DBBIS.crud("SELECT nama_jurusan FROM jurusan");
                        if (DBBIS.ds.Tables[0].Rows.Count > 0)
                        {
                            CmbJurusan.DataSource = DBBIS.ds.Tables[0];
                            CmbJurusan.DisplayMember = "nama_jurusan";
                        }

                        DBBIS.crud("SELECT nama_agama FROM agama"); 
                        if (DBBIS.ds.Tables[0].Rows.Count > 0)
                        {
                            CmbAgama.DataSource = DBBIS.ds.Tables[0];
                            CmbAgama.DisplayMember = "nama_agama";
                        }

                        string jurusanTerpilih = "" + brs["jurusan"];
                        string singkatan = "";
                        if (jurusanTerpilih == "Rekayasa Perangkat Lunak") { singkatan = "RPL"; }
                        else if (jurusanTerpilih == "Teknik Komputer dan Jaringan") { singkatan = "TKJ"; }
                        else if (jurusanTerpilih == "Teknik Pendingin dan Tata Udara") { singkatan = "TPTU"; }
                        else if (jurusanTerpilih == "Teknik Elektronika Industri") { singkatan = "TEI"; }

                        DBBIS.crud($"SELECT nama_kelas FROM kelas WHERE nama_kelas LIKE '%{singkatan}%'");
                        if (DBBIS.ds.Tables[0].Rows.Count > 0)
                        {
                            CmbKelas.DataSource = DBBIS.ds.Tables[0];
                            CmbKelas.DisplayMember = "nama_kelas";
                        }

                        TxtNipd.Text = "" + brs["nipd"];
                        TxtNisn.Text = "" + brs["nisn"];
                        TxtNama.Text = "" + brs["nama_lengkap"];

                        CmbJurusan.Text = jurusanTerpilih;
                        CmbKelas.Text = "" + brs["kelas"];
                        CmbAgama.Text = "" + brs["agama"];

                        TxtTmpLahir.Text = "" + brs["tmp_lahir"];
                        DTPTglLahir.Value = Convert.ToDateTime(brs["tgl_lahir"]);

                        TxtNmAyah.Text = "" + brs["nama_ayah"];
                        TxtNmIbu.Text = "" + brs["nama_ibu"];
                        TxtAlamat.Text = "" + brs["alamat_domisili"];

                        string gender = "" + brs["jenis_kelamin"];
                        if (gender == "Laki-laki") { RBLakilaki.Checked = true; }
                        else if (gender == "Perempuan") { RBPerempuan.Checked = true; }

                        CmbJurusan.SelectedIndexChanged += CmbJurusan_SelectedIndexChanged;
                    }
                    tampildata();
            }


            if (column == 9)
                {
                    Nipd_pilih = guna2DataGridView1.Rows[row].Cells[7].Value.ToString();
                    DialogResult setuju = MessageBox.Show("Apakah mau hapus? " + Nipd_pilih, "pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (setuju == DialogResult.Yes)
                    {
                        DBBIS.crud($"DELETE FROM siswa WHERE Nipd = '{Nipd_pilih}'");
                    }
                    tampildata();
                }
            }
        }

        private void BtnBatal_Click_1(object sender, EventArgs e)
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

            CmbJurusan.MaxDropDownItems = 4;
        }

        private void CmbKelas_DropDown(object sender, EventArgs e)
        {
            //CmbKelas.DataSource = null;
            //DBBIS.crud("SELECT nama_kelas FROM kelas");
            //CmbKelas.DataSource = DBBIS.ds.Tables[0];
            //CmbKelas.DisplayMember = "nama_kelas";

            //CmbKelas.MaxDropDownItems = 4;
        }

        private void CmbAgama_DropDown(object sender, EventArgs e)
        {
            CmbAgama.DataSource = null;
            DBBIS.crud("SELECT nama_agama FROM agama");
            CmbAgama.DataSource = DBBIS.ds.Tables[0];
            CmbAgama.DisplayMember = "nama_agama";

            CmbAgama.MaxDropDownItems = 4;
        }

        private void CmbJurusan_SelectedIndexChanged(object sender, EventArgs e)
        {
               if (CmbJurusan.SelectedIndex != -1 && CmbJurusan.Text != "")
                {
                    string singkatan = "";

                    if (CmbJurusan.Text == "Rekayasa Perangkat Lunak")
                    {
                        singkatan = "RPL";
                    }
                    else if (CmbJurusan.Text == "Teknik Komputer dan Jaringan")
                    {
                        singkatan = "TKJ";
                    }
                    else if (CmbJurusan.Text == "Teknik Pendingin dan Tata Udara")
                    {
                        singkatan = "TPTU";
                    }
                    else if (CmbJurusan.Text == "Teknik Elektronika Industri")
                    {
                        singkatan = "TEI";
                    }

                    CmbKelas.DataSource = null;
                    CmbKelas.Items.Clear();

                    DBBIS.crud($"SELECT nama_kelas FROM kelas WHERE nama_kelas LIKE '%{singkatan}%'");

                    if (DBBIS.ds.Tables[0].Rows.Count > 0)
                    {
                        CmbKelas.DataSource = DBBIS.ds.Tables[0];
                        CmbKelas.DisplayMember = "nama_kelas";

                        CmbKelas.SelectedIndex = -1;

                        CmbKelas.MaxDropDownItems = 4;
                    }
                }
            
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            // 1. Pilih file Excel
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files (*.xlsx; *.xls)|*.xlsx;*.xls";
            openFileDialog.Title = "Pilih File Excel Siswa";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    // 2. Baca file Excel menggunakan ExcelDataReader
                    using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true // Baris pertama Excel dianggap nama kolom
                                }
                            });

                            DataTable dt = result.Tables[0]; // Mengambil sheet pertama

                            // 3. Koneksi ke Database MySQL (Sesuaikan string koneksi Anda)
                            string connectionString = "server=localhost;database=dbbis;uid=root;pwd=;";

                            using (MySqlConnection conn = new MySqlConnection(connectionString))
                            {
                                conn.Open();

                                // Loop setiap baris di file Excel untuk dimasukkan ke database
                                foreach (DataRow row in dt.Rows)
                                {
                                    // Query SQL Insert sesuai dengan struktur tabel siswa Anda
                                    string query = @"INSERT INTO siswa 
                                            (nisn, jurusan, kelas, nama_lengkap, jenis_kelamin, tmp_lahir, tgl_lahir, agama, nama_ayah, nama_ibu, alamat_domisili) 
                                            VALUES 
                                            (@nisn, @jurusan, @kelas, @nama_lengkap, @jenis_kelamin, @tmp_lahir, @tgl_lahir, @agama, @nama_ayah, @nama_ibu, @alamat_domisili)";

                                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                                    {
                                        // Memetakan kolom Excel ke parameter database (Sesuaikan nama kolom di dalam row["..."])
                                        cmd.Parameters.AddWithValue("@nisn", row["nisn"].ToString());
                                        cmd.Parameters.AddWithValue("@jurusan", row["jurusan"].ToString());
                                        cmd.Parameters.AddWithValue("@kelas", row["kelas"].ToString());
                                        cmd.Parameters.AddWithValue("@nama_lengkap", row["nama_lengkap"].ToString());
                                        cmd.Parameters.AddWithValue("@jenis_kelamin", row["jenis_kelamin"].ToString());
                                        cmd.Parameters.AddWithValue("@tmp_lahir", row["tmp_lahir"].ToString());

                                        // Parsing tanggal lahir agar formatnya sesuai dengan MySQL (YYYY-MM-DD)
                                        DateTime tglLahir = Convert.ToDateTime(row["tgl_lahir"]);
                                        cmd.Parameters.AddWithValue("@tgl_lahir", tglLahir.ToString("yyyy-MM-dd"));

                                        cmd.Parameters.AddWithValue("@agama", row["agama"].ToString());
                                        cmd.Parameters.AddWithValue("@nama_ayah", row["nama_ayah"].ToString());
                                        cmd.Parameters.AddWithValue("@nama_ibu", row["nama_ibu"].ToString());
                                        cmd.Parameters.AddWithValue("@alamat_domisili", row["alamat_domisili"].ToString());

                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }

                            MessageBox.Show("Semua data siswa berhasil di-import ke database!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                tampildata();
            }
        }
    }
}