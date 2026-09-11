
namespace BukuIndukSekolah
{
    partial class FCDashboard
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
            this.PnlContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PnlContent
            // 
            this.PnlContent.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContent.Location = new System.Drawing.Point(0, 0);
            this.PnlContent.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.PnlContent.Name = "PnlContent";
            this.PnlContent.Size = new System.Drawing.Size(1549, 1008);
            this.PnlContent.TabIndex = 9;
            // 
            // FCDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 1008);
            this.Controls.Add(this.PnlContent);
            this.Name = "FCDashboard";
            this.Text = "FCDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlContent;
    }
}