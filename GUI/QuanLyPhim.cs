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
    public partial class QuanLyPhim : Form
    {
        PhimBLL phimBLL;
        int RowEnter = 0;
        public QuanLyPhim()
        {
            InitializeComponent();
            phimBLL = new PhimBLL();
        }

        private void QuanLyPhim_Load(object sender, EventArgs e)
        {
            phimBLL.DanhSachPhim(dgvPhim);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenPhim, theLoai, moTa;
            DateTime khoiChieu;
            tenPhim = txtTenPhim.Text;
            theLoai = txtTheLoai.Text;
            moTa = txtMoTa.Text;
            khoiChieu = DateTime.Parse(txtNgayKhoiChieu.Text);
            if (phimBLL.ThemPhim(tenPhim, theLoai, khoiChieu, moTa )) QuanLyPhim_Load(sender, e);
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string tenPhim, theLoai, moTa;
            DateTime khoiChieu;
            tenPhim = txtTenPhim.Text;
            theLoai = txtTheLoai.Text;
            moTa = txtMoTa.Text;
            khoiChieu = DateTime.Parse(txtNgayKhoiChieu.Text);
            if (phimBLL.UpdatePhim(tenPhim, theLoai, khoiChieu, moTa)) QuanLyPhim_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string tenPhim, theLoai, moTa;
            DateTime khoiChieu;
            tenPhim = txtTenPhim.Text;
            theLoai = txtTheLoai.Text;
            moTa = txtMoTa.Text;
            khoiChieu = DateTime.Parse(txtNgayKhoiChieu.Text);
            if (phimBLL.XoaPhim(tenPhim, theLoai, khoiChieu, moTa)) QuanLyPhim_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtTenPhim.Text = dgvPhim.Rows[RowEnter].Cells[0].Value.ToString();
            txtTheLoai.Text = dgvPhim.Rows[RowEnter].Cells[1].Value.ToString();
            txtNgayKhoiChieu.Text = dgvPhim.Rows[RowEnter].Cells[3].Value.ToString();
            txtMoTa.Text = dgvPhim.Rows[RowEnter].Cells[2].Value.ToString();
        }

        private void dgvPhim_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            RowEnter = e.RowIndex;
            txtTenPhim.Text = dgvPhim.Rows[RowEnter].Cells[0].Value.ToString();
            txtTheLoai.Text = dgvPhim.Rows[RowEnter].Cells[1].Value.ToString();
            txtNgayKhoiChieu.Text = dgvPhim.Rows[RowEnter].Cells[3].Value.ToString();
            txtMoTa.Text = dgvPhim.Rows[RowEnter].Cells[2].Value.ToString();
        }
    }
}
