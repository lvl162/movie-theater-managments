namespace QuanLyRapPhim
{
    partial class DatVe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbChonCaChieu = new System.Windows.Forms.ComboBox();
            this.cbChonPhim = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btcancel = new System.Windows.Forms.Button();
            this.butinhoadon = new System.Windows.Forms.Button();
            this.btchonghe = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(922, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đặt vé";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phòng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenPhong);
            this.panel2.Controls.Add(this.txtMoTa);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbChonCaChieu);
            this.panel2.Controls.Add(this.cbChonPhim);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btcancel);
            this.panel2.Controls.Add(this.butinhoadon);
            this.panel2.Controls.Add(this.btchonghe);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 486);
            this.panel2.TabIndex = 4;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(243, 150);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.ReadOnly = true;
            this.txtTenPhong.Size = new System.Drawing.Size(262, 22);
            this.txtTenPhong.TabIndex = 12;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(622, 8);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(189, 164);
            this.txtMoTa.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Chọ ca chiếu:";
            // 
            // cbChonCaChieu
            // 
            this.cbChonCaChieu.FormattingEnabled = true;
            this.cbChonCaChieu.Location = new System.Drawing.Point(243, 93);
            this.cbChonCaChieu.Margin = new System.Windows.Forms.Padding(4);
            this.cbChonCaChieu.Name = "cbChonCaChieu";
            this.cbChonCaChieu.Size = new System.Drawing.Size(261, 24);
            this.cbChonCaChieu.TabIndex = 9;
            this.cbChonCaChieu.SelectedIndexChanged += new System.EventHandler(this.cbChonCaChieu_SelectedIndexChanged);
            // 
            // cbChonPhim
            // 
            this.cbChonPhim.FormattingEnabled = true;
            this.cbChonPhim.Location = new System.Drawing.Point(243, 35);
            this.cbChonPhim.Margin = new System.Windows.Forms.Padding(4);
            this.cbChonPhim.Name = "cbChonPhim";
            this.cbChonPhim.Size = new System.Drawing.Size(261, 24);
            this.cbChonPhim.TabIndex = 8;
            this.cbChonPhim.SelectedIndexChanged += new System.EventHandler(this.cbChonPhim_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chọn phim:";
            // 
            // btcancel
            // 
            this.btcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancel.Location = new System.Drawing.Point(413, 212);
            this.btcancel.Margin = new System.Windows.Forms.Padding(4);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(92, 34);
            this.btcancel.TabIndex = 6;
            this.btcancel.Text = "Cancel";
            this.btcancel.UseVisualStyleBackColor = true;
            // 
            // butinhoadon
            // 
            this.butinhoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butinhoadon.Location = new System.Drawing.Point(243, 212);
            this.butinhoadon.Margin = new System.Windows.Forms.Padding(4);
            this.butinhoadon.Name = "butinhoadon";
            this.butinhoadon.Size = new System.Drawing.Size(92, 34);
            this.butinhoadon.TabIndex = 4;
            this.butinhoadon.Text = "In hóa đơn";
            this.butinhoadon.UseVisualStyleBackColor = true;
            // 
            // btchonghe
            // 
            this.btchonghe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btchonghe.Location = new System.Drawing.Point(73, 212);
            this.btchonghe.Margin = new System.Windows.Forms.Padding(4);
            this.btchonghe.Name = "btchonghe";
            this.btchonghe.Size = new System.Drawing.Size(92, 34);
            this.btchonghe.TabIndex = 4;
            this.btchonghe.Text = "Chọn ghế";
            this.btchonghe.UseVisualStyleBackColor = true;
            // 
            // DatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 483);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DatVe";
            this.Text = "DatVe";
            this.Load += new System.EventHandler(this.DatVe_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Button butinhoadon;
        private System.Windows.Forms.Button btchonghe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbChonCaChieu;
        private System.Windows.Forms.ComboBox cbChonPhim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenPhong;
    }
}