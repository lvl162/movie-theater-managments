using BLL;
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
    public partial class LichChieu : Form
    {
        int RowEnter = 0;
        public LichChieu()
        {
            InitializeComponent();
            
        }
        LichChieuBLL lichChieuBLL = new LichChieuBLL();

        private void LichChieu_Load(object sender, EventArgs e)
        {
            dgvLichChieu.AutoGenerateColumns = false;
            dgvLichChieu.DataSource = lichChieuBLL.DanhSachLichChieu();
            dgvLichChieu.Rows[0].Selected = false;
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            new DatVe().ShowDialog();
        }

        private void dgvLichChieu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RowEnter = e.RowIndex;
                txtTenPhim.Text = dgvLichChieu.Rows[RowEnter].Cells[0].Value.ToString();
                txtNgayChieu.Text = dgvLichChieu.Rows[RowEnter].Cells[1].Value.ToString();
                txtGioChieu.Text = dgvLichChieu.Rows[RowEnter].Cells[2].Value.ToString();
                txtTenPhong.Text = dgvLichChieu.Rows[RowEnter].Cells[3].Value.ToString();
                int maLichChieu = int.Parse(dgvLichChieu.Rows[RowEnter].Cells[4].Value.ToString());
                int maPhong = int.Parse(dgvLichChieu.Rows[RowEnter].Cells[5].Value.ToString());
                txtGheTrong.Text = lichChieuBLL.getSoGheTrong(maPhong, maLichChieu) + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvLichChieu.DataSource = lichChieuBLL.Search(txtSearch.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
