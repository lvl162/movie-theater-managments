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
        public QuanLyPhong()
        {
            InitializeComponent();
            lbHi.Text = $"Hi {Login.UserName}!";
            pcBLL = new PhongChieuBLL();
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
                dgvPhong.AutoGenerateColumns = false;
                dgvPhong.DataSource = pcBLL.DanhSachPhongChieu();
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

                    if (pcBLL.XoaPhong(maPhong))
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
    }
}
