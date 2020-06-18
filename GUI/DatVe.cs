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
            try
            {
                cbChonPhim.DataSource = datVeBLL.LayDanhSachPhim();
                cbChonPhim.DisplayMember = "TenPhim";
                cbChonPhim.ValueMember = "MaPhim";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cbChonCaChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var lichchieu = cbChonCaChieu.SelectedItem as LichChieuDTO;
                var phong = datVeBLL.LayPhongTheoLichChieu(lichchieu.MaPhong);
                txtTenPhong.ReadOnly = false;
                txtTenPhong.Text = phong.TenPhong;
                txtTenPhong.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbChonPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var phim = cbChonPhim.SelectedItem as PhimDTO;
                txtMoTa.Text = phim.MoTa;
                cbChonCaChieu.DataSource = datVeBLL.LayDanhSachLichChieu(phim.MaPhim);
                cbChonCaChieu.DisplayMember = "NgayGioChieu";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
