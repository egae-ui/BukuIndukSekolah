namespace BukuIndukSekolah
{
    partial class WaliKelas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnTambah = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlCrud = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbKelas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbGuru = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTahunAjaran = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.BtnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.ColNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColJurusan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTahun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdHidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColHapus = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.PnlCrud.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 30;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNo,
            this.ColKelas,
            this.ColJurusan,
            this.ColWali,
            this.ColTahun,
            this.ColIdHidden,
            this.ColEdit,
            this.ColHapus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.LightSeaGreen;
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 250);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 62;
            this.guna2DataGridView1.RowTemplate.Height = 28;
            this.guna2DataGridView1.Size = new System.Drawing.Size(916, 411);
            this.guna2DataGridView1.TabIndex = 9;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.LightSeaGreen;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 28;
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.TxtSearch);
            this.panel1.Controls.Add(this.BtnTambah);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 250);
            this.panel1.TabIndex = 7;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSearch.DefaultText = "";
            this.TxtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearch.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.TxtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearch.Location = new System.Drawing.Point(13, 102);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PlaceholderText = "Search";
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.Size = new System.Drawing.Size(368, 35);
            this.TxtSearch.TabIndex = 2;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // BtnTambah
            // 
            this.BtnTambah.AutoRoundedCorners = true;
            this.BtnTambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnTambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnTambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnTambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnTambah.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnTambah.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.BtnTambah.ForeColor = System.Drawing.Color.White;
            this.BtnTambah.Location = new System.Drawing.Point(386, 102);
            this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Size = new System.Drawing.Size(113, 35);
            this.BtnTambah.TabIndex = 0;
            this.BtnTambah.Text = "Tambah";
            this.BtnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 24F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manajemen Wali Kelas";
            // 
            // PnlCrud
            // 
            this.PnlCrud.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PnlCrud.Controls.Add(this.label2);
            this.PnlCrud.Controls.Add(this.CmbKelas);
            this.PnlCrud.Controls.Add(this.label3);
            this.PnlCrud.Controls.Add(this.CmbGuru);
            this.PnlCrud.Controls.Add(this.label4);
            this.PnlCrud.Controls.Add(this.TxtTahunAjaran);
            this.PnlCrud.Controls.Add(this.BtnSimpan);
            this.PnlCrud.Controls.Add(this.BtnBatal);
            this.PnlCrud.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlCrud.Location = new System.Drawing.Point(916, 0);
            this.PnlCrud.Name = "PnlCrud";
            this.PnlCrud.Size = new System.Drawing.Size(310, 661);
            this.PnlCrud.TabIndex = 8;
            this.PnlCrud.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kelas";
            // 
            // CmbKelas
            // 
            this.CmbKelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbKelas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CmbKelas.Location = new System.Drawing.Point(11, 42);
            this.CmbKelas.Name = "CmbKelas";
            this.CmbKelas.Size = new System.Drawing.Size(286, 33);
            this.CmbKelas.TabIndex = 0;
            this.CmbKelas.DropDown += new System.EventHandler(this.CmbKelas_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Wali Kelas (Guru)";
            // 
            // CmbGuru
            // 
            this.CmbGuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGuru.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CmbGuru.Location = new System.Drawing.Point(11, 112);
            this.CmbGuru.Name = "CmbGuru";
            this.CmbGuru.Size = new System.Drawing.Size(286, 33);
            this.CmbGuru.TabIndex = 1;
            this.CmbGuru.DropDown += new System.EventHandler(this.CmbGuru_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.label4.Location = new System.Drawing.Point(6, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tahun Ajaran";
            // 
            // TxtTahunAjaran
            // 
            this.TxtTahunAjaran.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTahunAjaran.DefaultText = "";
            this.TxtTahunAjaran.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtTahunAjaran.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtTahunAjaran.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTahunAjaran.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTahunAjaran.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTahunAjaran.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtTahunAjaran.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTahunAjaran.Location = new System.Drawing.Point(11, 184);
            this.TxtTahunAjaran.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTahunAjaran.Name = "TxtTahunAjaran";
            this.TxtTahunAjaran.PlaceholderText = "Contoh: 2026";
            this.TxtTahunAjaran.SelectedText = "";
            this.TxtTahunAjaran.Size = new System.Drawing.Size(286, 36);
            this.TxtTahunAjaran.TabIndex = 2;
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.AutoRoundedCorners = true;
            this.BtnSimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSimpan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnSimpan.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.BtnSimpan.ForeColor = System.Drawing.Color.White;
            this.BtnSimpan.Location = new System.Drawing.Point(12, 232);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(286, 36);
            this.BtnSimpan.TabIndex = 5;
            this.BtnSimpan.Text = "Simpan";
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // BtnBatal
            // 
            this.BtnBatal.AutoRoundedCorners = true;
            this.BtnBatal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBatal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBatal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBatal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBatal.FillColor = System.Drawing.Color.Gray;
            this.BtnBatal.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.BtnBatal.ForeColor = System.Drawing.Color.White;
            this.BtnBatal.Location = new System.Drawing.Point(11, 276);
            this.BtnBatal.Name = "BtnBatal";
            this.BtnBatal.Size = new System.Drawing.Size(286, 36);
            this.BtnBatal.TabIndex = 12;
            this.BtnBatal.Text = "Batal";
            this.BtnBatal.Click += new System.EventHandler(this.BtnBatal_Click);
            // 
            // ColNo
            // 
            this.ColNo.HeaderText = "No";
            this.ColNo.MinimumWidth = 8;
            this.ColNo.Name = "ColNo";
            this.ColNo.ReadOnly = true;
            // 
            // ColKelas
            // 
            this.ColKelas.HeaderText = "Kelas";
            this.ColKelas.MinimumWidth = 8;
            this.ColKelas.Name = "ColKelas";
            this.ColKelas.ReadOnly = true;
            // 
            // ColJurusan
            // 
            this.ColJurusan.HeaderText = "Jurusan";
            this.ColJurusan.MinimumWidth = 8;
            this.ColJurusan.Name = "ColJurusan";
            this.ColJurusan.ReadOnly = true;
            // 
            // ColWali
            // 
            this.ColWali.HeaderText = "Wali Kelas";
            this.ColWali.MinimumWidth = 8;
            this.ColWali.Name = "ColWali";
            this.ColWali.ReadOnly = true;
            // 
            // ColTahun
            // 
            this.ColTahun.HeaderText = "Tahun Ajaran";
            this.ColTahun.MinimumWidth = 8;
            this.ColTahun.Name = "ColTahun";
            this.ColTahun.ReadOnly = true;
            // 
            // ColIdHidden
            // 
            this.ColIdHidden.HeaderText = "ID";
            this.ColIdHidden.MinimumWidth = 8;
            this.ColIdHidden.Name = "ColIdHidden";
            this.ColIdHidden.ReadOnly = true;
            this.ColIdHidden.Visible = false;
            // 
            // ColEdit
            // 
            this.ColEdit.HeaderText = "Edit";
            this.ColEdit.MinimumWidth = 8;
            this.ColEdit.Name = "ColEdit";
            this.ColEdit.ReadOnly = true;
            this.ColEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColHapus
            // 
            this.ColHapus.HeaderText = "Delete";
            this.ColHapus.MinimumWidth = 8;
            this.ColHapus.Name = "ColHapus";
            this.ColHapus.ReadOnly = true;
            this.ColHapus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // WaliKelas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1226, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.PnlCrud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WaliKelas";
            this.Text = "Manajemen Wali Kelas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlCrud.ResumeLayout(false);
            this.PnlCrud.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearch;
        private Guna.UI2.WinForms.Guna2Button BtnTambah;
        private System.Windows.Forms.Panel PnlCrud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbKelas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbGuru;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TxtTahunAjaran;
        private Guna.UI2.WinForms.Guna2Button BtnSimpan;
        private Guna.UI2.WinForms.Guna2Button BtnBatal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColJurusan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWali;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTahun;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdHidden;
        private System.Windows.Forms.DataGridViewButtonColumn ColEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColHapus;
    }
}
