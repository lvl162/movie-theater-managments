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
using DTO;

namespace QuanLyRapPhim
{
    public partial class QuanLyNhanVien : Form
    {
        int RowEnter = 0;
        NhanVienBLL quanLyNhanVienBLL = new NhanVienBLL();
        List<NhanVienDTO> list = new List<NhanVienDTO>();
        public QuanLyNhanVien()
        {
            InitializeComponent();
            lbHi.Text = $"Hi {Login.UserName}!";
            cbOptions.SelectedIndex = 0;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thêm?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
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
                    if (quanLyNhanVienBLL.ThemNhanVien(HoTen, NgaySinh, GioiTinh, SoCMND, SDT, ChucVu, DiaChi))
                    {
                        MessageBox.Show("Thêm thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                QuanLyNhanVien_Load(sender, e);
            }
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                list = quanLyNhanVienBLL.DanhSachNhanVien();
                dgvNhanVien.AutoGenerateColumns = false;
                dgvNhanVien.DataSource = list;
                txtSearch.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    int maNV = int.Parse(dgvNhanVien.Rows[RowEnter].Cells[0].Value.ToString());

                    if (quanLyNhanVienBLL.XoaNhanVien(maNV))
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                QuanLyNhanVien_Load(sender, e);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn sửa?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    int maNV = int.Parse(dgvNhanVien.Rows[RowEnter].Cells[0].Value.ToString());
                    string HoTen, SDT, SoCMND, GioiTinh, DiaChi, ChucVu, RowVer;
                    DateTime NgaySinh;
                    HoTen = txtHoTen.Text;
                    SDT = txtSDT.Text;
                    SoCMND = txtCMND.Text;
                    GioiTinh = cbNamNu.SelectedItem.ToString();
                    ChucVu = cbChucVu.SelectedItem.ToString();
                    DiaChi = txtDiaChi.Text;
                    NgaySinh = timePickerNgaySinh.Value.Date;
                    RowVer = dgvNhanVien.Rows[RowEnter].Cells[8].Value.ToString();
                    if (quanLyNhanVienBLL.UpdateNhanVien(maNV, HoTen, NgaySinh, GioiTinh, SoCMND, SDT, ChucVu, DiaChi, RowVer))
                        MessageBox.Show("Update thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                QuanLyNhanVien_Load(sender, e);
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            //TODO: messagebox 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                txtHoTen.Text = dgvNhanVien.Rows[RowEnter].Cells[1].Value.ToString();
                timePickerNgaySinh.Value = DateTime.Parse(dgvNhanVien.Rows[RowEnter].Cells[2].Value.ToString());
                cbNamNu.SelectedItem = dgvNhanVien.Rows[RowEnter].Cells[3].Value.ToString();
                txtCMND.Text = dgvNhanVien.Rows[RowEnter].Cells[4].Value.ToString();
                txtSDT.Text = dgvNhanVien.Rows[RowEnter].Cells[5].Value.ToString();
                cbChucVu.SelectedItem = dgvNhanVien.Rows[RowEnter].Cells[6].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[RowEnter].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQuanLyLogin_Click(object sender, EventArgs e)
        {
            new QuanLyLoginUser().ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = txtSearch.Text.ToLower();
                int index = cbOptions.SelectedIndex;
                if (index == 0)
                {
                    dgvNhanVien.DataSource = list.Where(nv => Utils.convertToUnSign(nv.HoVaTen).ToLower().Contains(text)).ToList();
                }
                if (index == 1)
                {
                    dgvNhanVien.DataSource = list.Where(nv => nv.NgaySinh.ToString("dd/MM/yyyy").Contains(text)).ToList();
                }
                if (index == 2)
                {
                    dgvNhanVien.DataSource = list.Where(nv => Utils.convertToUnSign(nv.GioiTinh).ToLower().Contains(text)).ToList();
                }
                if (index == 3)
                {
                    dgvNhanVien.DataSource = list.Where(nv => nv.SoCMND.Contains(text)).ToList();
                }
                if (index == 4)
                {
                    dgvNhanVien.DataSource = list.Where(nv => nv.SDT.Contains(text)).ToList();
                }
                if (index == 5)
                {
                    dgvNhanVien.DataSource = list.Where(nv => Utils.convertToUnSign(nv.ChucVu).ToLower().Contains(text)).ToList();
                }
                if (index == 6)
                {
                    dgvNhanVien.DataSource = list.Where(nv => Utils.convertToUnSign(nv.DiaChi).ToLower().Contains(text)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
