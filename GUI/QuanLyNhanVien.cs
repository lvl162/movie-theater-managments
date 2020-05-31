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
        int RowEnter = 0;
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
            // TODO: else ..
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            quanLyBLL.DanhSachNhanVien(dgvNhanVien);
        }

        private void dgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            RowEnter = e.RowIndex;
            txtHoTen.Text = dgvNhanVien.Rows[RowEnter].Cells[1].Value.ToString();
            timePickerNgaySinh.Value = DateTime.Parse(dgvNhanVien.Rows[RowEnter].Cells[2].Value.ToString());
            cbNamNu.SelectedItem = dgvNhanVien.Rows[RowEnter].Cells[3].Value.ToString();
            txtCMND.Text = dgvNhanVien.Rows[RowEnter].Cells[4].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[RowEnter].Cells[5].Value.ToString();
            cbChucVu.SelectedItem = dgvNhanVien.Rows[RowEnter].Cells[6].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[RowEnter].Cells[7].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int maNV = int.Parse(dgvNhanVien.Rows[RowEnter].Cells[0].Value.ToString());
            string HoTen, SDT, SoCMND, GioiTinh, DiaChi, ChucVu;
            DateTime NgaySinh;
            HoTen = txtHoTen.Text;
            SDT = txtSDT.Text;
            SoCMND = txtCMND.Text;
            GioiTinh = cbNamNu.SelectedItem.ToString();
            ChucVu = cbChucVu.SelectedItem.ToString();
            DiaChi = txtDiaChi.Text;
            NgaySinh = timePickerNgaySinh.Value.Date;

            if (quanLyBLL.XoaNhanVien(maNV, HoTen, NgaySinh, GioiTinh, SoCMND, SDT, ChucVu, DiaChi)) QuanLyNhanVien_Load(sender, e);
            // TODO: else ..
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int maNV = int.Parse(dgvNhanVien.Rows[RowEnter].Cells[0].Value.ToString());
            string HoTen, SDT, SoCMND, GioiTinh, DiaChi, ChucVu;
            DateTime NgaySinh;
            HoTen = txtHoTen.Text;
            SDT = txtSDT.Text;
            SoCMND = txtCMND.Text;
            GioiTinh = cbNamNu.SelectedItem.ToString();
            ChucVu = cbChucVu.SelectedItem.ToString();
            DiaChi = txtDiaChi.Text;
            NgaySinh = timePickerNgaySinh.Value.Date;

            if (quanLyBLL.UpdateNhanVien(maNV, HoTen, NgaySinh, GioiTinh, SoCMND, SDT, ChucVu, DiaChi)) QuanLyNhanVien_Load(sender, e);
            // TODO: else ..
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            //TODO: messagebox 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = dgvNhanVien.Rows[RowEnter].Cells[1].Value.ToString();
            timePickerNgaySinh.Value = DateTime.Parse(dgvNhanVien.Rows[RowEnter].Cells[2].Value.ToString());
            cbNamNu.SelectedItem = dgvNhanVien.Rows[RowEnter].Cells[3].Value.ToString();
            txtCMND.Text = dgvNhanVien.Rows[RowEnter].Cells[4].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[RowEnter].Cells[5].Value.ToString();
            cbChucVu.SelectedItem = dgvNhanVien.Rows[RowEnter].Cells[6].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[RowEnter].Cells[7].Value.ToString();
        }

        private void btnQuanLyLogin_Click(object sender, EventArgs e)
        {
            new QuanLyLoginUser().ShowDialog();
        }
    }
}
