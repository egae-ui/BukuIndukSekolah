namespace BukuIndukSekolah
{
    partial class LaporanSiswa
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
            this.PnlTop           = new System.Windows.Forms.Panel();
            this.LblJudul         = new System.Windows.Forms.Label();
            this.PnlFilter        = new System.Windows.Forms.Panel();
            this.LblJurusan       = new System.Windows.Forms.Label();
            this.CmbFilterJurusan = new System.Windows.Forms.ComboBox();
            this.LblKelas         = new System.Windows.Forms.Label();
            this.CmbFilterKelas   = new System.Windows.Forms.ComboBox();
            this.BtnTampil        = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCetak         = new Guna.UI2.WinForms.Guna2Button();
            this.LblTotal         = new System.Windows.Forms.Label();
            this.dgvLaporan       = new System.Windows.Forms.DataGridView();
            this.PnlTop.SuspendLayout();
            this.PnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.Teal;
            this.PnlTop.Controls.Add(this.LblJudul);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(1400, 65);
            this.PnlTop.TabIndex = 0;
            // 
            // LblJudul
            // 
            this.LblJudul.AutoSize = true;
            this.LblJudul.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.LblJudul.ForeColor = System.Drawing.Color.White;
            this.LblJudul.Location = new System.Drawing.Point(18, 16);
            this.LblJudul.Name = "LblJudul";
            this.LblJudul.TabIndex = 0;
            this.LblJudul.Text = "Laporan Data Siswa";
            // 
            // PnlFilter
            // 
            this.PnlFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.PnlFilter.Controls.Add(this.LblTotal);
            this.PnlFilter.Controls.Add(this.BtnCetak);
            this.PnlFilter.Controls.Add(this.BtnTampil);
            this.PnlFilter.Controls.Add(this.CmbFilterKelas);
            this.PnlFilter.Controls.Add(this.LblKelas);
            this.PnlFilter.Controls.Add(this.CmbFilterJurusan);
            this.PnlFilter.Controls.Add(this.LblJurusan);
            this.PnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlFilter.Location = new System.Drawing.Point(0, 65);
            this.PnlFilter.Name = "PnlFilter";
            this.PnlFilter.Size = new System.Drawing.Size(1400, 60);
            this.PnlFilter.TabIndex = 1;
            // 
            // LblJurusan
            // 
            this.LblJurusan.AutoSize = true;
            this.LblJurusan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LblJurusan.ForeColor = System.Drawing.Color.White;
            this.LblJurusan.Location = new System.Drawing.Point(15, 19);
            this.LblJurusan.Name = "LblJurusan";
            this.LblJurusan.TabIndex = 0;
            this.LblJurusan.Text = "Jurusan :";
            // 
            // CmbFilterJurusan
            // 
            this.CmbFilterJurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFilterJurusan.Font = new System.Drawing.Font("Arial", 10F);
            this.CmbFilterJurusan.FormattingEnabled = true;
            this.CmbFilterJurusan.Location = new System.Drawing.Point(121, 16);
            this.CmbFilterJurusan.Name = "CmbFilterJurusan";
            this.CmbFilterJurusan.Size = new System.Drawing.Size(280, 31);
            this.CmbFilterJurusan.TabIndex = 1;
            this.CmbFilterJurusan.SelectedIndexChanged += new System.EventHandler(this.CmbFilterJurusan_SelectedIndexChanged);
            // 
            // LblKelas
            // 
            this.LblKelas.AutoSize = true;
            this.LblKelas.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LblKelas.ForeColor = System.Drawing.Color.White;
            this.LblKelas.Location = new System.Drawing.Point(427, 23);
            this.LblKelas.Name = "LblKelas";
            this.LblKelas.TabIndex = 2;
            this.LblKelas.Text = "Kelas :";
            // 
            // CmbFilterKelas
            // 
            this.CmbFilterKelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFilterKelas.Font = new System.Drawing.Font("Arial", 10F);
            this.CmbFilterKelas.FormattingEnabled = true;
            this.CmbFilterKelas.Location = new System.Drawing.Point(520, 16);
            this.CmbFilterKelas.Name = "CmbFilterKelas";
            this.CmbFilterKelas.Size = new System.Drawing.Size(220, 31);
            this.CmbFilterKelas.TabIndex = 2;
            // 
            // BtnTampil
            // 
            this.BtnTampil.AutoRoundedCorners = true;
            this.BtnTampil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnTampil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnTampil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnTampil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnTampil.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.BtnTampil.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.BtnTampil.ForeColor = System.Drawing.Color.White;
            this.BtnTampil.Location = new System.Drawing.Point(758, 10);
            this.BtnTampil.Name = "BtnTampil";
            this.BtnTampil.Size = new System.Drawing.Size(140, 40);
            this.BtnTampil.TabIndex = 3;
            this.BtnTampil.Text = "Tampilkan";
            this.BtnTampil.Click += new System.EventHandler(this.BtnTampil_Click);
            // 
            // BtnCetak
            // 
            this.BtnCetak.AutoRoundedCorners = true;
            this.BtnCetak.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCetak.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCetak.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCetak.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCetak.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnCetak.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.BtnCetak.ForeColor = System.Drawing.Color.White;
            this.BtnCetak.Location = new System.Drawing.Point(904, 10);
            this.BtnCetak.Name = "BtnCetak";
            this.BtnCetak.Size = new System.Drawing.Size(160, 40);
            this.BtnCetak.TabIndex = 4;
            this.BtnCetak.Text = "Cetak / Preview";
            this.BtnCetak.Click += new System.EventHandler(this.BtnCetak_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LblTotal.ForeColor = System.Drawing.Color.White;
            this.LblTotal.Location = new System.Drawing.Point(1070, 18);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.TabIndex = 5;
            this.LblTotal.Text = "Total: 0 siswa";
            // 
            // dgvLaporan
            // 
            this.dgvLaporan.AllowUserToAddRows = false;
            this.dgvLaporan.AllowUserToDeleteRows = false;
            this.dgvLaporan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLaporan.BackgroundColor = System.Drawing.Color.White;
            this.dgvLaporan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLaporan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLaporan.ColumnHeadersHeight = 32;
            this.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLaporan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLaporan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLaporan.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dgvLaporan.Location = new System.Drawing.Point(0, 125);
            this.dgvLaporan.Name = "dgvLaporan";
            this.dgvLaporan.ReadOnly = true;
            this.dgvLaporan.RowHeadersVisible = false;
            this.dgvLaporan.RowHeadersWidth = 62;
            this.dgvLaporan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLaporan.Size = new System.Drawing.Size(1400, 775);
            this.dgvLaporan.TabIndex = 2;
            // 
            // LaporanSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.dgvLaporan);
            this.Controls.Add(this.PnlFilter);
            this.Controls.Add(this.PnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LaporanSiswa";
            this.Text = "Laporan Data Siswa";
            this.Load += new System.EventHandler(this.LaporanSiswa_Load);
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            this.PnlFilter.ResumeLayout(false);
            this.PnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Label LblJudul;
        private System.Windows.Forms.Panel PnlFilter;
        private System.Windows.Forms.Label LblJurusan;
        private System.Windows.Forms.ComboBox CmbFilterJurusan;
        private System.Windows.Forms.Label LblKelas;
        private System.Windows.Forms.ComboBox CmbFilterKelas;
        private Guna.UI2.WinForms.Guna2Button BtnTampil;
        private Guna.UI2.WinForms.Guna2Button BtnCetak;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridView dgvLaporan;
    }
}
