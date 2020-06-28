namespace QuanLyRapPhim
{
    partial class QuanLyLichChieu
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
            this.dgvDSLichChieu = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbLichChieuInfo = new System.Windows.Forms.GroupBox();
            this.lbHi = new System.Windows.Forms.Label();
            this.cbPhongs = new System.Windows.Forms.ComboBox();
            this.cbPhims = new System.Windows.Forms.ComboBox();
            this.lichChieuPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOptions = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.MaLichChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGioChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLichChieu)).BeginInit();
            this.gbLichChieuInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSLichChieu
            // 
            this.dgvDSLichChieu.AllowUserToAddRows = false;
            this.dgvDSLichChieu.AllowUserToDeleteRows = false;
            this.dgvDSLichChieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSLichChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLichChieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLichChieu,
            this.MaPhong,
            this.MaPhim,
            this.NgayGioChieu,
            this.RowVersion,
            this.TenPhong,
            this.TenPhim,
            this.MoTa});
            this.dgvDSLichChieu.Location = new System.Drawing.Point(12, 276);
            this.dgvDSLichChieu.Name = "dgvDSLichChieu";
            this.dgvDSLichChieu.ReadOnly = true;
            this.dgvDSLichChieu.RowHeadersVisible = false;
            this.dgvDSLichChieu.RowHeadersWidth = 51;
            this.dgvDSLichChieu.RowTemplate.Height = 24;
            this.dgvDSLichChieu.Size = new System.Drawing.Size(728, 291);
            this.dgvDSLichChieu.TabIndex = 0;
            this.dgvDSLichChieu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLichChieu_RowEnter);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(321, 206);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 42);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(172, 206);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 42);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 206);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 42);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbLichChieuInfo
            // 
            this.gbLichChieuInfo.Controls.Add(this.lbHi);
            this.gbLichChieuInfo.Controls.Add(this.cbPhongs);
            this.gbLichChieuInfo.Controls.Add(this.cbPhims);
            this.gbLichChieuInfo.Controls.Add(this.lichChieuPicker);
            this.gbLichChieuInfo.Controls.Add(this.label3);
            this.gbLichChieuInfo.Controls.Add(this.label2);
            this.gbLichChieuInfo.Controls.Add(this.label1);
            this.gbLichChieuInfo.Location = new System.Drawing.Point(12, 0);
            this.gbLichChieuInfo.Name = "gbLichChieuInfo";
            this.gbLichChieuInfo.Size = new System.Drawing.Size(964, 162);
            this.gbLichChieuInfo.TabIndex = 7;
            this.gbLichChieuInfo.TabStop = false;
            this.gbLichChieuInfo.Text = "Thông tin lịch chiếu";
            // 
            // lbHi
            // 
            this.lbHi.AutoSize = true;
            this.lbHi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHi.Location = new System.Drawing.Point(864, 23);
            this.lbHi.Name = "lbHi";
            this.lbHi.Size = new System.Drawing.Size(53, 20);
            this.lbHi.TabIndex = 13;
            this.lbHi.Text = "label4";
            // 
            // cbPhongs
            // 
            this.cbPhongs.FormattingEnabled = true;
            this.cbPhongs.Location = new System.Drawing.Point(504, 62);
            this.cbPhongs.Name = "cbPhongs";
            this.cbPhongs.Size = new System.Drawing.Size(274, 24);
            this.cbPhongs.TabIndex = 12;
            // 
            // cbPhims
            // 
            this.cbPhims.FormattingEnabled = true;
            this.cbPhims.Location = new System.Drawing.Point(504, 19);
            this.cbPhims.Name = "cbPhims";
            this.cbPhims.Size = new System.Drawing.Size(274, 24);
            this.cbPhims.TabIndex = 12;
            // 
            // lichChieuPicker
            // 
            this.lichChieuPicker.CustomFormat = "dd/MM/yyyy hh:mm";
            this.lichChieuPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lichChieuPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lichChieuPicker.Location = new System.Drawing.Point(504, 109);
            this.lichChieuPicker.Name = "lichChieuPicker";
            this.lichChieuPicker.Size = new System.Drawing.Size(274, 26);
            this.lichChieuPicker.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chọn giờ chiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chọn phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Chọn phim ";
            // 
            // cbOptions
            // 
            this.cbOptions.FormattingEnabled = true;
            this.cbOptions.Items.AddRange(new object[] {
            "Tên phim",
            "Tên phòng",
            "Ngày giờ chiếu"});
            this.cbOptions.Location = new System.Drawing.Point(619, 216);
            this.cbOptions.Name = "cbOptions";
            this.cbOptions.Size = new System.Drawing.Size(121, 24);
            this.cbOptions.TabIndex = 12;
            this.cbOptions.SelectedIndexChanged += new System.EventHandler(this.cbOptions_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(462, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tìm kiếm bằng";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(789, 212);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(169, 28);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pbPoster
            // 
            this.pbPoster.Location = new System.Drawing.Point(746, 276);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(237, 291);
            this.pbPoster.TabIndex = 13;
            this.pbPoster.TabStop = false;
            // 
            // MaLichChieu
            // 
            this.MaLichChieu.DataPropertyName = "MaLichChieu";
            this.MaLichChieu.FillWeight = 50F;
            this.MaLichChieu.HeaderText = "Mã lịch chiếu";
            this.MaLichChieu.MinimumWidth = 6;
            this.MaLichChieu.Name = "MaLichChieu";
            this.MaLichChieu.ReadOnly = true;
            this.MaLichChieu.Visible = false;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.FillWeight = 50F;
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            this.MaPhong.Visible = false;
            // 
            // MaPhim
            // 
            this.MaPhim.DataPropertyName = "MaPhim";
            this.MaPhim.FillWeight = 50F;
            this.MaPhim.HeaderText = "Mã phim";
            this.MaPhim.MinimumWidth = 6;
            this.MaPhim.Name = "MaPhim";
            this.MaPhim.ReadOnly = true;
            this.MaPhim.Visible = false;
            // 
            // NgayGioChieu
            // 
            this.NgayGioChieu.DataPropertyName = "NgayGioChieu";
            this.NgayGioChieu.FillWeight = 150F;
            this.NgayGioChieu.HeaderText = "Ngày giờ chiếu";
            this.NgayGioChieu.MinimumWidth = 6;
            this.NgayGioChieu.Name = "NgayGioChieu";
            this.NgayGioChieu.ReadOnly = true;
            // 
            // RowVersion
            // 
            this.RowVersion.DataPropertyName = "RowVersion";
            this.RowVersion.HeaderText = "RowVersion";
            this.RowVersion.MinimumWidth = 6;
            this.RowVersion.Name = "RowVersion";
            this.RowVersion.ReadOnly = true;
            this.RowVersion.Visible = false;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên phòng";
            this.TenPhong.MinimumWidth = 6;
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.ReadOnly = true;
            // 
            // TenPhim
            // 
            this.TenPhim.DataPropertyName = "TenPhim";
            this.TenPhim.HeaderText = "Tên phim";
            this.TenPhim.MinimumWidth = 6;
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.ReadOnly = true;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "PhimMoTa";
            this.MoTa.HeaderText = "MotTa";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Visible = false;
            // 
            // QuanLyLichChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 579);
            this.Controls.Add(this.pbPoster);
            this.Controls.Add(this.cbOptions);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gbLichChieuInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvDSLichChieu);
            this.Name = "QuanLyLichChieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QuanLyLichChieu";
            this.Load += new System.EventHandler(this.QuanLyLichChieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLichChieu)).EndInit();
            this.gbLichChieuInfo.ResumeLayout(false);
            this.gbLichChieuInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSLichChieu;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbLichChieuInfo;
        private System.Windows.Forms.DateTimePicker lichChieuPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPhongs;
        private System.Windows.Forms.ComboBox cbPhims;
        private System.Windows.Forms.Label lbHi;
        private System.Windows.Forms.ComboBox cbOptions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLichChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGioChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
    }
}