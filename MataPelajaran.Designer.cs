namespace BukuIndukSekolah
{
    partial class MataPelajaran
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle cs1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cs2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cs3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColNo       = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKode     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNama     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKet      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdHidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdit     = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColHapus    = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1      = new System.Windows.Forms.Panel();
            this.label1      = new System.Windows.Forms.Label();
            this.TxtSearch   = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnTambah   = new Guna.UI2.WinForms.Guna2Button();
            this.PnlCrud     = new System.Windows.Forms.Panel();
            this.label2      = new System.Windows.Forms.Label();
            this.TxtKode     = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3      = new System.Windows.Forms.Label();
            this.TxtNamaMapel = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4      = new System.Windows.Forms.Label();
            this.TxtKeterangan = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnSimpan   = new Guna.UI2.WinForms.Guna2Button();
            this.BtnBatal    = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.PnlCrud.SuspendLayout();
            this.SuspendLayout();

            // guna2DataGridView1
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            cs1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = cs1;
            cs2.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            cs2.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            cs2.ForeColor = System.Drawing.Color.White;
            cs2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = cs2;
            this.guna2DataGridView1.ColumnHeadersHeight = 30;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.ColNo, this.ColKode, this.ColNama, this.ColKet,
                this.ColIdHidden, this.ColEdit, this.ColHapus });
            cs3.BackColor = System.Drawing.Color.White;
            cs3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            cs3.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            cs3.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            this.guna2DataGridView1.DefaultCellStyle = cs3;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.LightSeaGreen;
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 250);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowTemplate.Height = 28;
            this.guna2DataGridView1.Size = new System.Drawing.Size(916, 411);
            this.guna2DataGridView1.TabIndex = 9;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.LightSeaGreen;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);

            this.ColNo.HeaderText = "No"; this.ColNo.Width = 50; this.ColNo.ReadOnly = true;
            this.ColKode.HeaderText = "Kode"; this.ColKode.Width = 100; this.ColKode.ReadOnly = true;
            this.ColNama.HeaderText = "Nama Mata Pelajaran"; this.ColNama.Width = 350; this.ColNama.ReadOnly = true;
            this.ColKet.HeaderText = "Keterangan"; this.ColKet.Width = 300; this.ColKet.ReadOnly = true;
            this.ColIdHidden.HeaderText = "ID"; this.ColIdHidden.Visible = false; this.ColIdHidden.ReadOnly = true;
            this.ColEdit.HeaderText = "Edit"; this.ColEdit.Width = 70; this.ColEdit.ReadOnly = true;
            this.ColEdit.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColHapus.HeaderText = "Hapus"; this.ColHapus.Width = 70; this.ColHapus.ReadOnly = true;
            this.ColHapus.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            // panel1
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.TxtSearch);
            this.panel1.Controls.Add(this.BtnTambah);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Name = "panel1"; this.panel1.Size = new System.Drawing.Size(916, 250); this.panel1.TabIndex = 7;

            this.label1.AutoSize = true; this.label1.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 24F);
            this.label1.Location = new System.Drawing.Point(12, 9); this.label1.Name = "label1"; this.label1.Text = "Manajemen Mata Pelajaran";

            this.TxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam; this.TxtSearch.DefaultText = "";
            this.TxtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.TxtSearch.DisabledState.FillColor   = System.Drawing.Color.FromArgb(226, 226, 226);
            this.TxtSearch.DisabledState.ForeColor   = System.Drawing.Color.FromArgb(138, 138, 138);
            this.TxtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.TxtSearch.FocusedState.BorderColor  = System.Drawing.Color.FromArgb(94, 148, 255);
            this.TxtSearch.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.TxtSearch.HoverState.BorderColor    = System.Drawing.Color.FromArgb(94, 148, 255);
            this.TxtSearch.Location = new System.Drawing.Point(13, 102); this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PlaceholderText = "Search"; this.TxtSearch.SelectedText = "";
            this.TxtSearch.Size = new System.Drawing.Size(368, 35); this.TxtSearch.TabIndex = 2;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);

            this.BtnTambah.AutoRoundedCorners = true;
            this.BtnTambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnTambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnTambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.BtnTambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.BtnTambah.FillColor = System.Drawing.Color.FromArgb(0, 192, 0);
            this.BtnTambah.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.BtnTambah.ForeColor = System.Drawing.Color.White;
            this.BtnTambah.Location = new System.Drawing.Point(386, 102); this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Size = new System.Drawing.Size(113, 35); this.BtnTambah.TabIndex = 0;
            this.BtnTambah.Text = "Tambah"; this.BtnTambah.Click += new System.EventHandler(this.BtnTambah_Click);

            // PnlCrud
            this.PnlCrud.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PnlCrud.Controls.Add(this.label2); this.PnlCrud.Controls.Add(this.TxtKode);
            this.PnlCrud.Controls.Add(this.label3); this.PnlCrud.Controls.Add(this.TxtNamaMapel);
            this.PnlCrud.Controls.Add(this.label4); this.PnlCrud.Controls.Add(this.TxtKeterangan);
            this.PnlCrud.Controls.Add(this.BtnSimpan); this.PnlCrud.Controls.Add(this.BtnBatal);
            this.PnlCrud.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlCrud.Name = "PnlCrud"; this.PnlCrud.Size = new System.Drawing.Size(310, 661);
            this.PnlCrud.TabIndex = 8; this.PnlCrud.Visible = false;

            this.label2.AutoSize = true; this.label2.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.label2.Location = new System.Drawing.Point(6, 9); this.label2.Name = "label2"; this.label2.Text = "Kode Mapel";

            this.TxtKode.Cursor = System.Windows.Forms.Cursors.IBeam; this.TxtKode.DefaultText = "";
            this.TxtKode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.TxtKode.DisabledState.FillColor   = System.Drawing.Color.FromArgb(226, 226, 226);
            this.TxtKode.DisabledState.ForeColor   = System.Drawing.Color.FromArgb(138, 138, 138);
            this.TxtKode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.TxtKode.FocusedState.BorderColor  = System.Drawing.Color.FromArgb(94, 148, 255);
            this.TxtKode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtKode.HoverState.BorderColor    = System.Drawing.Color.FromArgb(94, 148, 255);
            this.TxtKode.Location = new System.Drawing.Point(11, 42); this.TxtKode.Name = "TxtKode";
            this.TxtKode.PlaceholderText = "Contoh: MAT"; this.TxtKode.SelectedText = "";
            this.TxtKode.Size = new System.Drawing.Size(286, 36); this.TxtKode.TabIndex = 0;

            this.label3.AutoSize = true; this.label3.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.label3.Location = new System.Drawing.Point(6, 88); this.label3.Name = "label3"; this.label3.Text = "Nama Mata Pelajaran";

            this.TxtNamaMapel.Cursor = System.Windows.Forms.Cursors.IBeam; this.TxtNamaMapel.DefaultText = "";
            this.TxtNamaMapel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.TxtNamaMapel.DisabledState.FillColor   = System.Drawing.Color.FromArgb(226, 226, 226);
            this.TxtNamaMapel.DisabledState.ForeColor   = System.Drawing.Color.FromArgb(138, 138, 138);
            this.TxtNamaMapel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.TxtNamaMapel.FocusedState.BorderColor  = System.Drawing.Color.FromArgb(94, 148, 255);
            this.TxtNamaMapel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtNamaMapel.HoverState.BorderColor    = System.Drawing.Color.FromArgb(94, 148, 255);
            this.TxtNamaMapel.Location = new System.Drawing.Point(11, 118); this.TxtNamaMapel.Name = "TxtNamaMapel";
            this.TxtNamaMapel.PlaceholderText = "Contoh: Matematika"; this.TxtNamaMapel.SelectedText = "";
            this.TxtNamaMapel.Size = new System.Drawing.Size(286, 36); this.TxtNamaMapel.TabIndex = 1;

            this.label4.AutoSize = true; this.label4.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.label4.Location = new System.Drawing.Point(6, 164); this.label4.Name = "label4"; this.label4.Text = "Keterangan";

            this.TxtKeterangan.Cursor = System.Windows.Forms.Cursors.IBeam; this.TxtKeterangan.DefaultText = "";
            this.TxtKeterangan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.TxtKeterangan.DisabledState.FillColor   = System.Drawing.Color.FromArgb(226, 226, 226);
            this.TxtKeterangan.DisabledState.ForeColor   = System.Drawing.Color.FromArgb(138, 138, 138);
            this.TxtKeterangan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.TxtKeterangan.FocusedState.BorderColor  = System.Drawing.Color.FromArgb(94, 148, 255);
            this.TxtKeterangan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtKeterangan.HoverState.BorderColor    = System.Drawing.Color.FromArgb(94, 148, 255);
            this.TxtKeterangan.Location = new System.Drawing.Point(11, 194); this.TxtKeterangan.Name = "TxtKeterangan";
            this.TxtKeterangan.PlaceholderText = "Opsional"; this.TxtKeterangan.SelectedText = "";
            this.TxtKeterangan.Size = new System.Drawing.Size(286, 36); this.TxtKeterangan.TabIndex = 2;

            this.BtnSimpan.AutoRoundedCorners = true;
            this.BtnSimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.BtnSimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.BtnSimpan.FillColor = System.Drawing.Color.FromArgb(0, 192, 0);
            this.BtnSimpan.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.BtnSimpan.ForeColor = System.Drawing.Color.White;
            this.BtnSimpan.Location = new System.Drawing.Point(12, 242); this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(286, 36); this.BtnSimpan.TabIndex = 5;
            this.BtnSimpan.Text = "Simpan"; this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);

            this.BtnBatal.AutoRoundedCorners = true;
            this.BtnBatal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBatal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBatal.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.BtnBatal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.BtnBatal.FillColor = System.Drawing.Color.Gray;
            this.BtnBatal.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.BtnBatal.ForeColor = System.Drawing.Color.White;
            this.BtnBatal.Location = new System.Drawing.Point(11, 286); this.BtnBatal.Name = "BtnBatal";
            this.BtnBatal.Size = new System.Drawing.Size(286, 36); this.BtnBatal.TabIndex = 12;
            this.BtnBatal.Text = "Batal"; this.BtnBatal.Click += new System.EventHandler(this.BtnBatal_Click);

            // Form
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1226, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.PnlCrud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MataPelajaran"; this.Text = "Manajemen Mata Pelajaran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.panel1.ResumeLayout(false); this.panel1.PerformLayout();
            this.PnlCrud.ResumeLayout(false); this.PnlCrud.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdHidden;
        private System.Windows.Forms.DataGridViewButtonColumn ColEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColHapus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearch;
        private Guna.UI2.WinForms.Guna2Button BtnTambah;
        private System.Windows.Forms.Panel PnlCrud;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TxtKode;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TxtNamaMapel;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TxtKeterangan;
        private Guna.UI2.WinForms.Guna2Button BtnSimpan;
        private Guna.UI2.WinForms.Guna2Button BtnBatal;
    }
}
