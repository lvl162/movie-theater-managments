namespace QuanLyRapPhim.DanhSachPhong
{
    partial class Phong1
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
            this.GhesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // GhesPanel
            // 
            this.GhesPanel.Location = new System.Drawing.Point(58, 86);
            this.GhesPanel.Name = "GhesPanel";
            this.GhesPanel.Size = new System.Drawing.Size(709, 353);
            this.GhesPanel.TabIndex = 0;
            // 
            // Phong1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 463);
            this.Controls.Add(this.GhesPanel);
            this.Name = "Phong1";
            this.Text = "Phong1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel GhesPanel;
    }
}