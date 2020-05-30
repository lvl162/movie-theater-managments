using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace QuanLyRapPhim
{
    public partial class QuanLyNhanVien : Form
    {
        QuanLyNhanVienBLL quanLyBLL = new QuanLyNhanVienBLL();
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string HoTen, SDT, SoCMND, GioiTinh, DiaChi, ChucVu;
            DateTime NgaySinh;
            HoTen = txtHoTen.Text;
            SDT = txtSDT.Text;
            SoCMND = txtCMND.Text;
            GioiTinh = cbNamNu.SelectedItem.ToString();
            ChucVu = cbChucVu.SelectedItem.ToString();
            DiaChi = txtDiaChi.Text;
            NgaySinh = timePickerNgaySinh.Value.Date;

            if (quanLyBLL.ThemNhanVien(HoTen, NgaySinh, GioiTinh, SoCMND, SDT, ChucVu, DiaChi)) QuanLyNhanVien_Load(sender, e);
            
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            quanLyBLL.DanhSachNhanVien(dgvNhanVien);
        }
    }
}
