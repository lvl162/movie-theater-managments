namespace QuanLyRapPhim
{
    partial class MenuForm
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
            this.btnDatVe = new System.Windows.Forms.Button();
            this.btnQLPhong = new System.Windows.Forms.Button();
            this.btnQLPhim = new System.Windows.Forms.Button();
            this.btnQLLichChieu = new System.Windows.Forms.Button();
            this.btnQLUser = new System.Windows.Forms.Button();
            this.btnQLNhanVien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDatVe
            // 
            this.btnDatVe.Location = new System.Drawing.Point(64, 33);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(101, 103);
            this.btnDatVe.TabIndex = 1;
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.UseVisualStyleBackColor = true;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // btnQLPhong
            // 
            this.btnQLPhong.Location = new System.Drawing.Point(236, 33);
            this.btnQLPhong.Name = "btnQLPhong";
            this.btnQLPhong.Size = new System.Drawing.Size(101, 103);
            this.btnQLPhong.TabIndex = 2;
            this.btnQLPhong.Text = "Quản lý phòng";
            this.btnQLPhong.UseVisualStyleBackColor = true;
            this.btnQLPhong.Click += new System.EventHandler(this.btnQLPhong_Click);
            // 
            // btnQLPhim
            // 
            this.btnQLPhim.Location = new System.Drawing.Point(415, 33);
            this.btnQLPhim.Name = "btnQLPhim";
            this.btnQLPhim.Size = new System.Drawing.Size(101, 103);
            this.btnQLPhim.TabIndex = 3;
            this.btnQLPhim.Text = "Quản lý phim";
            this.btnQLPhim.UseVisualStyleBackColor = true;
            this.btnQLPhim.Click += new System.EventHandler(this.btnQLPhim_Click);
            // 
            // btnQLLichChieu
            // 
            this.btnQLLichChieu.Location = new System.Drawing.Point(64, 199);
            this.btnQLLichChieu.Name = "btnQLLichChieu";
            this.btnQLLichChieu.Size = new System.Drawing.Size(101, 103);
            this.btnQLLichChieu.TabIndex = 4;
            this.btnQLLichChieu.Text = "Quản lý lịch chiếu";
            this.btnQLLichChieu.UseVisualStyleBackColor = true;
            this.btnQLLichChieu.Click += new System.EventHandler(this.btnQLLichChieu_Click);
            // 
            // btnQLUser
            // 
            this.btnQLUser.Location = new System.Drawing.Point(415, 199);
            this.btnQLUser.Name = "btnQLUser";
            this.btnQLUser.Size = new System.Drawing.Size(101, 103);
            this.btnQLUser.TabIndex = 6;
            this.btnQLUser.Text = "Quản lý App User";
            this.btnQLUser.UseVisualStyleBackColor = true;
            this.btnQLUser.Click += new System.EventHandler(this.btnQLUser_Click);
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.Location = new System.Drawing.Point(236, 199);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Size = new System.Drawing.Size(101, 103);
            this.btnQLNhanVien.TabIndex = 5;
            this.btnQLNhanVien.Text = "Quản lý nhân viên";
            this.btnQLNhanVien.UseVisualStyleBackColor = true;
            this.btnQLNhanVien.Click += new System.EventHandler(this.btnQLNhanVien_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 366);
            this.Controls.Add(this.btnQLNhanVien);
            this.Controls.Add(this.btnQLUser);
            this.Controls.Add(this.btnQLPhim);
            this.Controls.Add(this.btnQLLichChieu);
            this.Controls.Add(this.btnQLPhong);
            this.Controls.Add(this.btnDatVe);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Button btnQLPhong;
        private System.Windows.Forms.Button btnQLPhim;
        private System.Windows.Forms.Button btnQLLichChieu;
        private System.Windows.Forms.Button btnQLUser;
        private System.Windows.Forms.Button btnQLNhanVien;
    }
}