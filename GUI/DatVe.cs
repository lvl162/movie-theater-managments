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
        LichChieuDTO lc = null;
        public DatVe(LichChieuDTO lcDTO)
        {
            InitializeComponent();
            lbHi.Text = $"Hi {Login.UserName}!";
            lc = lcDTO;
            txtNgayChieu.Text = lcDTO.NgayChieu;
            txtTenPhim.Text = lcDTO.TenPhim;
            txtGioChieu.Text = lcDTO.GioChieu;
            txtTenPhong.Text = lcDTO.TenPhong;
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
