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
using QuanLyRapPhim;

namespace GUI
{
    public partial class QuanLyPhong : Form
    {
        PhongChieuBLL pcBLL;
        int RowEnter = 0;
        List<PhongChieuDTO> list = new List<PhongChieuDTO>();
        public QuanLyPhong()
        {
            InitializeComponent();
            lbHi.Text = $"Hi {Login.UserName}!";
            pcBLL = new PhongChieuBLL();
            dgvPhong.AutoGenerateColumns = false;
            cbOptions.SelectedIndex = 0;
        }
        private void dgvPhong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RowEnter = e.RowIndex;
                txtSoHang.Text = dgvPhong.Rows[RowEnter].Cells[2].Value.ToString();
                txtTenPhong.Text = dgvPhong.Rows[RowEnter].Cells[1].Value.ToString();
                txtSoCot.Text = dgvPhong.Rows[RowEnter].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void QuanLyPhong_Load(object sender, EventArgs e)
        {
            try
            {
                list = pcBLL.DanhSachPhongChieu();
                dgvPhong.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thêm?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    int soHang;
                    int soCot;
                    soHang = int.Parse(txtSoHang.Text);
                    soCot = int.Parse(txtSoCot.Text);

                    string tenPhong = txtTenPhong.Text;
                    if (pcBLL.ThemPhong(tenPhong, soHang, soCot))
                    {
                        MessageBox.Show("Thêm thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                QuanLyPhong_Load(sender, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn sửa?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    string rowVersion = dgvPhong.Rows[RowEnter].Cells[4].Value.ToString();
                    int maPhong = int.Parse(dgvPhong.Rows[RowEnter].Cells[0].Value.ToString());
                    int soHang;
                    int soCot;
                    soHang = int.Parse(txtSoHang.Text);
                    soCot = int.Parse(txtSoCot.Text);
                    string tenPhong = txtTenPhong.Text;
                    if (pcBLL.UpdatePhong(maPhong, soHang, soCot, tenPhong, rowVersion))
                    {
                        MessageBox.Show("Update thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                QuanLyPhong_Load(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    int maPhong = int.Parse(dgvPhong.Rows[RowEnter].Cells[0].Value.ToString());
                    string rowVersion = dgvPhong.Rows[RowEnter].Cells[4].Value.ToString();

                    if (pcBLL.XoaPhong(maPhong, rowVersion))
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                QuanLyPhong_Load(sender, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                txtSoHang.Text = dgvPhong.Rows[RowEnter].Cells[2].Value.ToString();
                txtTenPhong.Text = dgvPhong.Rows[RowEnter].Cells[1].Value.ToString();
                txtSoCot.Text = dgvPhong.Rows[RowEnter].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDSGhe_Click(object sender, EventArgs e)
        {
            new QuanLyGhe().ShowDialog();
        }

        private void cbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = cbOptions.SelectedIndex;
                string text = txtSearch.Text.ToLower();
                if (index == 0)
                {
                    dgvPhong.DataSource = list.Where(p => p.TenPhong.ToLower().Contains(text)).ToList();
                }
                if (index == 1)
                {
                    dgvPhong.DataSource = list.Where(p => p.SoHang.ToString().Contains(text)).ToList();
                }
                if (index == 2)
                {
                    dgvPhong.DataSource = list.Where(p => p.SoCot.ToString().Contains(text)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            QuanLyPhong_Load(sender, e);
        }
    }
}
