
namespace BukuIndukSekolah
{
    partial class DashPetugas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.LabelBar = new System.Windows.Forms.Label();
            this.PnlFooter = new System.Windows.Forms.Panel();
            this.BtnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.PnlContent = new System.Windows.Forms.Panel();
            this.PnlSidebar = new System.Windows.Forms.Panel();
            this.FlowPnlSide = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnDash = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDataM = new Guna.UI2.WinForms.Guna2Button();
            this.FPnlDataM = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnPengguna = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRole = new Guna.UI2.WinForms.Guna2Button();
            this.BtnKelas = new Guna.UI2.WinForms.Guna2Button();
            this.FPnlKelas = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnKelas7 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnKelas8 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnKelas9 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPelajaran = new Guna.UI2.WinForms.Guna2Button();
            this.BtnReport = new Guna.UI2.WinForms.Guna2Button();
            this.PnlHeader.SuspendLayout();
            this.PnlSidebar.SuspendLayout();
            this.FlowPnlSide.SuspendLayout();
            this.FPnlDataM.SuspendLayout();
            this.FPnlKelas.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PnlHeader.Controls.Add(this.LabelBar);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(300, 0);
            this.PnlHeader.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(1598, 126);
            this.PnlHeader.TabIndex = 11;
            // 
            // LabelBar
            // 
            this.LabelBar.AutoSize = true;
            this.LabelBar.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBar.Location = new System.Drawing.Point(42, 34);
            this.LabelBar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelBar.Name = "LabelBar";
            this.LabelBar.Size = new System.Drawing.Size(50, 57);
            this.LabelBar.TabIndex = 0;
            this.LabelBar.Text = "Ξ";
            this.LabelBar.Click += new System.EventHandler(this.LabelBar_Click);
            // 
            // PnlFooter
            // 
            this.PnlFooter.BackColor = System.Drawing.Color.Teal;
            this.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFooter.Location = new System.Drawing.Point(300, 1046);
            this.PnlFooter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PnlFooter.Name = "PnlFooter";
            this.PnlFooter.Size = new System.Drawing.Size(1598, 60);
            this.PnlFooter.TabIndex = 13;
            // 
            // BtnLogout
            // 
            this.BtnLogout.AutoRoundedCorners = true;
            this.BtnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnLogout.FillColor = System.Drawing.Color.Red;
            this.BtnLogout.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.Location = new System.Drawing.Point(0, 1044);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(298, 60);
            this.BtnLogout.TabIndex = 0;
            this.BtnLogout.Text = "LogOut";
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // PnlContent
            // 
            this.PnlContent.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContent.Location = new System.Drawing.Point(300, 126);
            this.PnlContent.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.PnlContent.Name = "PnlContent";
            this.PnlContent.Size = new System.Drawing.Size(1598, 920);
            this.PnlContent.TabIndex = 12;
            // 
            // PnlSidebar
            // 
            this.PnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlSidebar.Controls.Add(this.FlowPnlSide);
            this.PnlSidebar.Controls.Add(this.BtnLogout);
            this.PnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.PnlSidebar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.PnlSidebar.Name = "PnlSidebar";
            this.PnlSidebar.Size = new System.Drawing.Size(300, 1106);
            this.PnlSidebar.TabIndex = 10;
            // 
            // FlowPnlSide
            // 
            this.FlowPnlSide.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FlowPnlSide.Controls.Add(this.BtnDash);
            this.FlowPnlSide.Controls.Add(this.BtnDataM);
            this.FlowPnlSide.Controls.Add(this.FPnlDataM);
            this.FlowPnlSide.Controls.Add(this.BtnKelas);
            this.FlowPnlSide.Controls.Add(this.FPnlKelas);
            this.FlowPnlSide.Controls.Add(this.BtnPelajaran);
            this.FlowPnlSide.Controls.Add(this.BtnReport);
            this.FlowPnlSide.Location = new System.Drawing.Point(-2, 84);
            this.FlowPnlSide.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FlowPnlSide.Name = "FlowPnlSide";
            this.FlowPnlSide.Size = new System.Drawing.Size(302, 937);
            this.FlowPnlSide.TabIndex = 2;
            // 
            // BtnDash
            // 
            this.BtnDash.Animated = true;
            this.BtnDash.AutoRoundedCorners = true;
            this.BtnDash.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDash.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDash.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDash.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.BtnDash.ForeColor = System.Drawing.Color.White;
            this.BtnDash.Location = new System.Drawing.Point(6, 8);
            this.BtnDash.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.BtnDash.Name = "BtnDash";
            this.BtnDash.Size = new System.Drawing.Size(267, 71);
            this.BtnDash.TabIndex = 1;
            this.BtnDash.Text = "Dashboard";
            // 
            // BtnDataM
            // 
            this.BtnDataM.AutoRoundedCorners = true;
            this.BtnDataM.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDataM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDataM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDataM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDataM.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.BtnDataM.ForeColor = System.Drawing.Color.White;
            this.BtnDataM.Location = new System.Drawing.Point(6, 95);
            this.BtnDataM.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.BtnDataM.Name = "BtnDataM";
            this.BtnDataM.Size = new System.Drawing.Size(266, 69);
            this.BtnDataM.TabIndex = 5;
            this.BtnDataM.Text = "DataMaster";
            // 
            // FPnlDataM
            // 
            this.FPnlDataM.Controls.Add(this.BtnPengguna);
            this.FPnlDataM.Controls.Add(this.BtnRole);
            this.FPnlDataM.Location = new System.Drawing.Point(3, 175);
            this.FPnlDataM.Name = "FPnlDataM";
            this.FPnlDataM.Size = new System.Drawing.Size(287, 178);
            this.FPnlDataM.TabIndex = 0;
            this.FPnlDataM.Visible = false;
            // 
            // BtnPengguna
            // 
            this.BtnPengguna.AutoRoundedCorners = true;
            this.BtnPengguna.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPengguna.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPengguna.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPengguna.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPengguna.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.BtnPengguna.ForeColor = System.Drawing.Color.White;
            this.BtnPengguna.Location = new System.Drawing.Point(6, 8);
            this.BtnPengguna.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.BtnPengguna.Name = "BtnPengguna";
            this.BtnPengguna.Size = new System.Drawing.Size(266, 69);
            this.BtnPengguna.TabIndex = 5;
            this.BtnPengguna.Text = "Pengguna";
            // 
            // BtnRole
            // 
            this.BtnRole.AutoRoundedCorners = true;
            this.BtnRole.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRole.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRole.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.BtnRole.ForeColor = System.Drawing.Color.White;
            this.BtnRole.Location = new System.Drawing.Point(6, 93);
            this.BtnRole.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.BtnRole.Name = "BtnRole";
            this.BtnRole.Size = new System.Drawing.Size(266, 71);
            this.BtnRole.TabIndex = 6;
            this.BtnRole.Text = "Role";
            // 
            // BtnKelas
            // 
            this.BtnKelas.AutoRoundedCorners = true;
            this.BtnKelas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnKelas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnKelas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnKelas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnKelas.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.BtnKelas.ForeColor = System.Drawing.Color.White;
            this.BtnKelas.Location = new System.Drawing.Point(6, 364);
            this.BtnKelas.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.BtnKelas.Name = "BtnKelas";
            this.BtnKelas.Size = new System.Drawing.Size(266, 69);
            this.BtnKelas.TabIndex = 4;
            this.BtnKelas.Text = "Kelas";
            // 
            // FPnlKelas
            // 
            this.FPnlKelas.Controls.Add(this.BtnKelas7);
            this.FPnlKelas.Controls.Add(this.BtnKelas8);
            this.FPnlKelas.Controls.Add(this.BtnKelas9);
            this.FPnlKelas.Location = new System.Drawing.Point(3, 444);
            this.FPnlKelas.Name = "FPnlKelas";
            this.FPnlKelas.Size = new System.Drawing.Size(290, 271);
            this.FPnlKelas.TabIndex = 0;
            this.FPnlKelas.Visible = false;
            // 
            // BtnKelas7
            // 
            this.BtnKelas7.AutoRoundedCorners = true;
            this.BtnKelas7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnKelas7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnKelas7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnKelas7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnKelas7.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.BtnKelas7.ForeColor = System.Drawing.Color.White;
            this.BtnKelas7.Location = new System.Drawing.Point(6, 8);
            this.BtnKelas7.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.BtnKelas7.Name = "BtnKelas7";
            this.BtnKelas7.Size = new System.Drawing.Size(266, 69);
            this.BtnKelas7.TabIndex = 5;
            this.BtnKelas7.Text = "Kelas 7";
            // 
            // BtnKelas8
            // 
            this.BtnKelas8.AutoRoundedCorners = true;
            this.BtnKelas8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnKelas8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnKelas8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnKelas8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnKelas8.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.BtnKelas8.ForeColor = System.Drawing.Color.White;
            this.BtnKelas8.Location = new System.Drawing.Point(6, 93);
            this.BtnKelas8.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.BtnKelas8.Name = "BtnKelas8";
            this.BtnKelas8.Size = new System.Drawing.Size(266, 71);
            this.BtnKelas8.TabIndex = 6;
            this.BtnKelas8.Text = "Kelas 8";
            // 
            // BtnKelas9
            // 
            this.BtnKelas9.AutoRoundedCorners = true;
            this.BtnKelas9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnKelas9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnKelas9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnKelas9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnKelas9.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.BtnKelas9.ForeColor = System.Drawing.Color.White;
            this.BtnKelas9.Location = new System.Drawing.Point(6, 180);
            this.BtnKelas9.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.BtnKelas9.Name = "BtnKelas9";
            this.BtnKelas9.Size = new System.Drawing.Size(266, 71);
            this.BtnKelas9.TabIndex = 7;
            this.BtnKelas9.Text = "Kelas 9";
            // 
            // BtnPelajaran
            // 
            this.BtnPelajaran.AutoRoundedCorners = true;
            this.BtnPelajaran.BackColor = System.Drawing.Color.Transparent;
            this.BtnPelajaran.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPelajaran.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPelajaran.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPelajaran.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPelajaran.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.BtnPelajaran.ForeColor = System.Drawing.Color.White;
            this.BtnPelajaran.Location = new System.Drawing.Point(6, 726);
            this.BtnPelajaran.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.BtnPelajaran.Name = "BtnPelajaran";
            this.BtnPelajaran.Size = new System.Drawing.Size(266, 71);
            this.BtnPelajaran.TabIndex = 8;
            this.BtnPelajaran.Text = "Mata Pelajaran";
            // 
            // BtnReport
            // 
            this.BtnReport.AutoRoundedCorners = true;
            this.BtnReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnReport.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F);
            this.BtnReport.ForeColor = System.Drawing.Color.White;
            this.BtnReport.Location = new System.Drawing.Point(6, 813);
            this.BtnReport.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(266, 71);
            this.BtnReport.TabIndex = 9;
            this.BtnReport.Text = "Report";
            // 
            // DashTugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1106);
            this.Controls.Add(this.PnlContent);
            this.Controls.Add(this.PnlHeader);
            this.Controls.Add(this.PnlFooter);
            this.Controls.Add(this.PnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashTugas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashTugas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            this.PnlSidebar.ResumeLayout(false);
            this.FlowPnlSide.ResumeLayout(false);
            this.FPnlDataM.ResumeLayout(false);
            this.FPnlKelas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Label LabelBar;
        private System.Windows.Forms.Panel PnlFooter;
        private Guna.UI2.WinForms.Guna2Button BtnLogout;
        private System.Windows.Forms.Panel PnlContent;
        private System.Windows.Forms.Panel PnlSidebar;
        private System.Windows.Forms.FlowLayoutPanel FlowPnlSide;
        private Guna.UI2.WinForms.Guna2Button BtnDash;
        private Guna.UI2.WinForms.Guna2Button BtnDataM;
        private System.Windows.Forms.FlowLayoutPanel FPnlDataM;
        private Guna.UI2.WinForms.Guna2Button BtnPengguna;
        private Guna.UI2.WinForms.Guna2Button BtnRole;
        private Guna.UI2.WinForms.Guna2Button BtnKelas;
        private System.Windows.Forms.FlowLayoutPanel FPnlKelas;
        private Guna.UI2.WinForms.Guna2Button BtnKelas7;
        private Guna.UI2.WinForms.Guna2Button BtnKelas8;
        private Guna.UI2.WinForms.Guna2Button BtnKelas9;
        private Guna.UI2.WinForms.Guna2Button BtnPelajaran;
        private Guna.UI2.WinForms.Guna2Button BtnReport;
    }
}