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
    public partial class BanVe : Form
    {
        DatVeBLL datVeBLL = new DatVeBLL();
        LichChieuDTO lc = null;
        public BanVe(LichChieuDTO lcDTO)
        {
            InitializeComponent();
            lbHi.Text = $"Hi {Login.UserName}!";
            lc = lcDTO;
            txtNgayChieu.Text = lcDTO.NgayChieu;
            txtTenPhim.Text = lcDTO.TenPhim;
            txtGioChieu.Text = lcDTO.GioChieu;
            pbPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            txtTenPhong.Text = lcDTO.TenPhong;
            pbPoster.Image = Image.FromFile(NVBVForm.posterPath);
        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            PhongDatVe phongDatVe = new PhongDatVe(lc);
            phongDatVe.Text = "Phòng " + txtTenPhong.Text;
            phongDatVe.ShowDialog();
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
