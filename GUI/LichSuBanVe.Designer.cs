namespace QuanLyRapPhim
{
    partial class LichSuBanVe
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
            this.dgvLichSuBanVe = new System.Windows.Forms.DataGridView();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBanVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchBy = new System.Windows.Forms.Label();
            this.cbOptions = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuBanVe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichSuBanVe
            // 
            this.dgvLichSuBanVe.AllowUserToAddRows = false;
            this.dgvLichSuBanVe.AllowUserToDeleteRows = false;
            this.dgvLichSuBanVe.AllowUserToOrderColumns = true;
            this.dgvLichSuBanVe.AllowUserToResizeColumns = false;
            this.dgvLichSuBanVe.AllowUserToResizeRows = false;
            this.dgvLichSuBanVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSuBanVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuBanVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenPhim,
            this.NgayChieu,
            this.TenPhong,
            this.TenGhe,
            this.NguoiBan,
            this.ThoiGianBanVe});
            this.dgvLichSuBanVe.Location = new System.Drawing.Point(12, 93);
            this.dgvLichSuBanVe.Name = "dgvLichSuBanVe";
            this.dgvLichSuBanVe.RowHeadersVisible = false;
            this.dgvLichSuBanVe.RowHeadersWidth = 51;
            this.dgvLichSuBanVe.RowTemplate.Height = 24;
            this.dgvLichSuBanVe.Size = new System.Drawing.Size(901, 371);
            this.dgvLichSuBanVe.TabIndex = 0;
            // 
            // TenPhim
            // 
            this.TenPhim.DataPropertyName = "TenPhim";
            this.TenPhim.HeaderText = "Tên phim";
            this.TenPhim.MinimumWidth = 6;
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.ReadOnly = true;
            // 
            // NgayChieu
            // 
            this.NgayChieu.DataPropertyName = "NgayGioChieu";
            this.NgayChieu.HeaderText = "Lịch chiếu";
            this.NgayChieu.MinimumWidth = 6;
            this.NgayChieu.Name = "NgayChieu";
            this.NgayChieu.ReadOnly = true;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.FillWeight = 40F;
            this.TenPhong.HeaderText = "Tên phòng";
            this.TenPhong.MinimumWidth = 6;
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.ReadOnly = true;
            // 
            // TenGhe
            // 
            this.TenGhe.DataPropertyName = "TenGhe";
            this.TenGhe.FillWeight = 40F;
            this.TenGhe.HeaderText = "Tên ghế";
            this.TenGhe.MinimumWidth = 6;
            this.TenGhe.Name = "TenGhe";
            this.TenGhe.ReadOnly = true;
            // 
            // NguoiBan
            // 
            this.NguoiBan.DataPropertyName = "NguoiBan";
            this.NguoiBan.HeaderText = "Người bán";
            this.NguoiBan.MinimumWidth = 6;
            this.NguoiBan.Name = "NguoiBan";
            this.NguoiBan.ReadOnly = true;
            // 
            // ThoiGianBanVe
            // 
            this.ThoiGianBanVe.DataPropertyName = "ThoiGianBan";
            this.ThoiGianBanVe.HeaderText = "Vé đã bán lúc";
            this.ThoiGianBanVe.MinimumWidth = 6;
            this.ThoiGianBanVe.Name = "ThoiGianBanVe";
            this.ThoiGianBanVe.ReadOnly = true;
            // 
            // SearchBy
            // 
            this.SearchBy.AutoSize = true;
            this.SearchBy.Location = new System.Drawing.Point(12, 29);
            this.SearchBy.Name = "SearchBy";
            this.SearchBy.Size = new System.Drawing.Size(100, 17);
            this.SearchBy.TabIndex = 1;
            this.SearchBy.Text = "Tìm kiếm bằng";
            // 
            // cbOptions
            // 
            this.cbOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOptions.FormattingEnabled = true;
            this.cbOptions.Items.AddRange(new object[] {
            "Tên phim",
            "Lịch chiếu",
            "Tên phòng",
            "Tên ghế",
            "Người bán",
            "Vé đã bán lúc"});
            this.cbOptions.Location = new System.Drawing.Point(128, 22);
            this.cbOptions.Name = "cbOptions";
            this.cbOptions.Size = new System.Drawing.Size(151, 24);
            this.cbOptions.TabIndex = 2;
            this.cbOptions.SelectedIndexChanged += new System.EventHandler(this.cbOptions_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(338, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(230, 22);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(704, 21);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(84, 41);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // LichSuBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 476);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbOptions);
            this.Controls.Add(this.SearchBy);
            this.Controls.Add(this.dgvLichSuBanVe);
            this.Name = "LichSuBanVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LichSuBanVe";
            this.Load += new System.EventHandler(this.LichSuBanVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuBanVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLichSuBanVe;
        private System.Windows.Forms.Label SearchBy;
        private System.Windows.Forms.ComboBox cbOptions;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBanVe;
        private System.Windows.Forms.Button btnReload;
    }
}