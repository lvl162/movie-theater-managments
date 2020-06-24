using BLL;
using DTO;
using QuanLyRapPhim.DanhSachPhong;
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
            lbHi.Text = $"Hi {Login.UserName}!";
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
                if (lichchieu != null)
                {
                    var phong = datVeBLL.LayPhongTheoLichChieu(lichchieu.MaPhong);
                    int e_s = datVeBLL.getSoGheTrong(lichchieu);
                    if (phong != null)
                    {
                        txtTenPhong.Text = phong.TenPhong;
                        txtSoGheTrong.Text = datVeBLL.getSoGheTrong(lichchieu) + "";
                    }
                    else
                    {
                        txtTenPhong.Text = "Không tìm thấy phòng";
                        txtSoGheTrong.Text = "";
                    }
                }
                else
                {
                    txtTenPhong.Text = "Không tìm thấy phòng";
                    txtSoGheTrong.Text = "";
                }
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
                if (datVeBLL.LayDanhSachLichChieu(phim.MaPhim).Count != 0)
                {
                    cbChonCaChieu.DataSource = datVeBLL.LayDanhSachLichChieu(phim.MaPhim);
                    cbChonCaChieu.DisplayMember = "GioChieuAndPhong";
                    cbChonCaChieu.ValueMember = "MaLichChieu";                    
                }
                else
                {
                    cbChonCaChieu.DataSource = new List<string>() { "Không có lịch chiếu cho phim này" };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            int maLC;
            LichChieuDTO lc = cbChonCaChieu.SelectedItem as LichChieuDTO;
            maLC = lc.MaLichChieu;
            int maPhong = lc.MaPhong;
            string tenphong = lc.TenPhong;
            new PhongDatVe(lc).ShowDialog();
        }
    }
}
