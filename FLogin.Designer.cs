
namespace BukuIndukSekolah
{
    partial class FLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.TxtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Controls.Add(this.TxtPass);
            this.panel1.Controls.Add(this.TxtUser);
            this.panel1.Location = new System.Drawing.Point(42, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 377);
            this.panel1.TabIndex = 2;
            // 
            // BtnLogin
            // 
            this.BtnLogin.AutoRoundedCorners = true;
            this.BtnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogin.FillColor = System.Drawing.Color.Blue;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(35, 205);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(195, 36);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // TxtPass
            // 
            this.TxtPass.AutoRoundedCorners = true;
            this.TxtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPass.DefaultText = "";
            this.TxtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPass.Location = new System.Drawing.Point(35, 152);
            this.TxtPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '*';
            this.TxtPass.PlaceholderText = "Password";
            this.TxtPass.SelectedText = "";
            this.TxtPass.Size = new System.Drawing.Size(195, 36);
            this.TxtPass.TabIndex = 1;
            this.TxtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPass_KeyPress);
            // 
            // TxtUser
            // 
            this.TxtUser.AutoRoundedCorners = true;
            this.TxtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUser.DefaultText = "";
            this.TxtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUser.Location = new System.Drawing.Point(35, 108);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.PlaceholderText = "Username";
            this.TxtUser.SelectedText = "";
            this.TxtUser.Size = new System.Drawing.Size(195, 36);
            this.TxtUser.TabIndex = 0;
            this.TxtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUser_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(305, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 377);
            this.panel2.TabIndex = 3;
            // 
            // FLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FLogin_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button BtnLogin;
        private Guna.UI2.WinForms.Guna2TextBox TxtPass;
        private Guna.UI2.WinForms.Guna2TextBox TxtUser;
        private System.Windows.Forms.Panel panel2;
    }
}

