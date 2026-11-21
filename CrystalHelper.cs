using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;

namespace BukuIndukSekolah
{
    public static class CrystalHelper
    {
        private static string RptPath =>
            Path.Combine(Application.StartupPath, "LaporanSiswa.rpt");

        public static void TampilLaporan(string kondisiWhere = "1=1")
        {
            try
            {
                if (!File.Exists(RptPath))
                {
                    MessageBox.Show("File LaporanSiswa.rpt tidak ditemukan di:\n" + RptPath,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sql =
                    "SELECT nipd, nisn, nama_lengkap, jurusan, kelas, jenis_kelamin, " +
                    "tmp_lahir, DATE_FORMAT(tgl_lahir,'%d-%m-%Y') AS tgl_lahir, " +
                    "agama, nama_ayah, nama_ibu, alamat_domisili " +
                    $"FROM siswa WHERE {kondisiWhere} " +
                    "ORDER BY jurusan, kelas, nama_lengkap";

                string connStr = "server=127.0.0.1;database=dbbis;uid=root;password=;";
                var dt = new DataTable("siswa");
                using (var da = new MySqlDataAdapter(sql, connStr))
                    da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Tidak ada data siswa untuk ditampilkan.",
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var rpt = new ReportDocument();
                rpt.Load(RptPath);
                rpt.SetDataSource(dt);

                var viewer = new FrmCrystalViewer(rpt);
                viewer.ShowDialog();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                if (ex.InnerException != null) msg += "\n\nDetail: " + ex.InnerException.Message;
                MessageBox.Show("Gagal membuka laporan:\n" + msg,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}