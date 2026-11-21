using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace BukuIndukSekolah
{
    /// <summary>
    /// Form viewer Crystal Reports. CrystalReportViewer dibuat runtime
    /// (tidak di Designer) agar VS Designer tidak perlu load CR DLL.
    /// </summary>
    public class FrmCrystalViewer : Form
    {
        private CrystalReportViewer _viewer;
        private ReportDocument      _rpt;

        public FrmCrystalViewer(ReportDocument rpt)
        {
            _rpt = rpt;
            InitForm();
        }

        private void InitForm()
        {
            // ── Form settings ────────────────────────────────────────
            this.Text            = "Laporan Data Siswa";
            this.WindowState     = FormWindowState.Maximized;
            this.StartPosition   = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.BackColor       = System.Drawing.Color.Teal;

            // ── Panel header ─────────────────────────────────────────
            var pnlHeader = new Panel();
            pnlHeader.Dock      = DockStyle.Top;
            pnlHeader.Height    = 50;
            pnlHeader.BackColor = System.Drawing.Color.Teal;

            var lblJudul = new Label();
            lblJudul.Text      = "Laporan Data Siswa — Buku Induk Sekolah";
            lblJudul.Font      = new System.Drawing.Font("Gloucester MT Extra Condensed", 16F,
                                     System.Drawing.FontStyle.Bold);
            lblJudul.ForeColor = System.Drawing.Color.White;
            lblJudul.AutoSize  = true;
            lblJudul.Location  = new System.Drawing.Point(15, 12);
            pnlHeader.Controls.Add(lblJudul);

            var btnTutup = new Button();
            btnTutup.Text      = "✕  Tutup";
            btnTutup.Font      = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            btnTutup.ForeColor = System.Drawing.Color.White;
            btnTutup.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            btnTutup.FlatStyle = FlatStyle.Flat;
            btnTutup.FlatAppearance.BorderSize = 0;
            btnTutup.Size      = new System.Drawing.Size(100, 35);
            btnTutup.Anchor    = AnchorStyles.Top | AnchorStyles.Right;
            btnTutup.Location  = new System.Drawing.Point(
                Screen.PrimaryScreen.WorkingArea.Width - 120, 7);
            btnTutup.Click += (s, e) => this.Close();
            pnlHeader.Controls.Add(btnTutup);

            // ── Crystal Reports Viewer ────────────────────────────────
            _viewer = new CrystalReportViewer();
            _viewer.Dock                   = DockStyle.Fill;
            _viewer.ActiveViewIndex        = -1;
            _viewer.BorderStyle            = BorderStyle.None;
            _viewer.ShowCloseButton        = false;
            _viewer.ShowExportButton       = true;
            _viewer.ShowGotoPageButton     = true;
            _viewer.ShowGroupTreeButton    = false;
            _viewer.ShowParameterPanelButton = false;
            _viewer.ShowPrintButton        = true;
            _viewer.ShowRefreshButton      = true;
            _viewer.ShowZoomButton         = true;
            _viewer.ReportSource           = _rpt;

            // ── Add controls (urutan penting untuk Dock) ─────────────
            this.Controls.Add(_viewer);     // Fill dulu
            this.Controls.Add(pnlHeader);   // Top di atas Fill

            // ── Cleanup saat form ditutup ─────────────────────────────
            this.FormClosed += (s, e) =>
            {
                _viewer.ReportSource = null;
                _rpt?.Close();
                _rpt?.Dispose();
            };
        }
    }
}
