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
namespace GUI
{
    public partial class QuanLyPhong : Form
    {
        QuanLyPhongChieuBLL pcBLL;
        int RowEnter = 0;
        public QuanLyPhong()
        {
            InitializeComponent();
        }
        private void dgvPhong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            RowEnter = e.RowIndex;
            txtSoGhe.Text = dgvPhong.Rows[RowEnter].Cells[1].Value.ToString();
            txtTenPhong.Text = dgvPhong.Rows[RowEnter].Cells[2].Value.ToString();
        }

        protected void QuanLyPhong_Load(object sender, EventArgs e)
        {
            pcBLL = new QuanLyPhongChieuBLL();
            pcBLL.DanhSachPhongChieu(dgvPhong);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int soGhe;
            int.TryParse(txtSoGhe.Text, out soGhe);
            string tenPhong = txtTenPhong.Text;
            if (pcBLL.ThemPhong(soGhe, tenPhong)) QuanLyPhong_Load(sender,e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int maPhong = int.Parse(dgvPhong.Rows[RowEnter].Cells[0].Value.ToString());
            int soGhe;
            int.TryParse(txtSoGhe.Text, out soGhe);
            string tenPhong = txtTenPhong.Text;
            if (pcBLL.UpdatePhong(maPhong, soGhe,tenPhong)) QuanLyPhong_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int soGhe;
            int maPhong = int.Parse(dgvPhong.Rows[RowEnter].Cells[0].Value.ToString());
            int.TryParse(txtSoGhe.Text, out soGhe);
            string tenPhong = txtTenPhong.Text;
            if (pcBLL.XoaPhong(maPhong, soGhe, tenPhong)) QuanLyPhong_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSoGhe.Text = dgvPhong.Rows[RowEnter].Cells[1].Value.ToString();
            txtTenPhong.Text = dgvPhong.Rows[RowEnter].Cells[2].Value.ToString();
        }
    }
}
