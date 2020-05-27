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
        PhongChieuBLL pcBLL;
        int RowEnter = 0;
        public QuanLyPhong()
        {
            InitializeComponent();
        }
        private void dgvPhong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            RowEnter = e.RowIndex;
            txtMaPhong.Text = dgvPhong.Rows[RowEnter].Cells[0].Value.ToString();
            txtSoGhe.Text = dgvPhong.Rows[RowEnter].Cells[1].Value.ToString();
            txtDienTich.Text = dgvPhong.Rows[RowEnter].Cells[2].Value.ToString();
        }

        protected void QuanLyPhong_Load(object sender, EventArgs e)
        {
            pcBLL = new PhongChieuBLL();
            pcBLL.DanhSachPhongChieu(dgvPhong);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text;
            int soGhe;
            int.TryParse(txtSoGhe.Text, out soGhe);
            float dienTich;
            float.TryParse(txtDienTich.Text, out dienTich);
            if (pcBLL.ThemPhong(maPhong, soGhe, dienTich)) QuanLyPhong_Load(sender,e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text;
            int soGhe;
            int.TryParse(txtSoGhe.Text, out soGhe);
            float dienTich;
            float.TryParse(txtDienTich.Text, out dienTich);
            if (pcBLL.UpdatePhong(maPhong, soGhe, dienTich)) QuanLyPhong_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text;
            int soGhe;
            int.TryParse(txtSoGhe.Text, out soGhe);
            float dienTich;
            float.TryParse(txtDienTich.Text, out dienTich);
            if (pcBLL.XoaPhong(maPhong, soGhe, dienTich)) QuanLyPhong_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaPhong.Text = dgvPhong.Rows[RowEnter].Cells[0].Value.ToString();
            txtSoGhe.Text = dgvPhong.Rows[RowEnter].Cells[1].Value.ToString();
            txtDienTich.Text = dgvPhong.Rows[RowEnter].Cells[2].Value.ToString();
        }
    }
}
