using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim
{
    public partial class DatVe : Form
    {
        DatVeBLL datVeBLL = new DatVeBLL();
        public DatVe()
        {
            InitializeComponent();
        }

        private void DatVe_Load(object sender, EventArgs e)
        {
            cbChonPhim.DataSource = datVeBLL.LayDanhSachPhim();
            cbChonPhim.DisplayMember = "TenPhim";
            cbChonPhim.ValueMember = "MaPhim";
        }
        private void cbChonCaChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lichchieu = cbChonCaChieu.SelectedItem as LichChieuDTO;
            var phong = datVeBLL.LayPhongTheoLichChieu(lichchieu.MaPhong);
            txtTenPhong.ReadOnly = false;
            txtTenPhong.Text = phong.TenPhong;
            txtTenPhong.ReadOnly = true;
        }

        private void cbChonPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            var phim = cbChonPhim.SelectedItem as PhimDTO;
            txtMoTa.Text = phim.MoTa;
            cbChonCaChieu.DataSource = datVeBLL.LayDanhSachLichChieu(phim.MaPhim);
            cbChonCaChieu.DisplayMember = "NgayGioChieu";
        }
    }
}
