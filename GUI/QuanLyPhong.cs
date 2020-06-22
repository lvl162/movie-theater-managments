using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
            pcBLL = new PhongChieuBLL();
        }
        private void dgvPhong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RowEnter = e.RowIndex;
                txtSoGhe.Text = dgvPhong.Rows[RowEnter].Cells[1].Value.ToString();
                txtTenPhong.Text = dgvPhong.Rows[RowEnter].Cells[2].Value.ToString();
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
            try
            {
                int soGhe;
                soGhe = int.Parse(txtSoGhe.Text);
                string tenPhong = txtTenPhong.Text;
                if (pcBLL.ThemPhong(soGhe, tenPhong)) 
                {
                    MessageBox.Show("Them thanh cong!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            QuanLyPhong_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string rowVersion = dgvPhong.Rows[RowEnter].Cells[3].Value.ToString();
                int maPhong = int.Parse(dgvPhong.Rows[RowEnter].Cells[0].Value.ToString());
                int soGhe;
                int.TryParse(txtSoGhe.Text, out soGhe);
                string tenPhong = txtTenPhong.Text;
                if (pcBLL.UpdatePhong(maPhong, soGhe, tenPhong, rowVersion)) { 
                    MessageBox.Show("Update thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            QuanLyPhong_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int soGhe;
                int maPhong = int.Parse(dgvPhong.Rows[RowEnter].Cells[0].Value.ToString());
                int.TryParse(txtSoGhe.Text, out soGhe);
                string tenPhong = txtTenPhong.Text;
                if (pcBLL.XoaPhong(maPhong, soGhe, tenPhong))
                {
                    MessageBox.Show("Xoa thanh cong!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            QuanLyPhong_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                txtSoGhe.Text = dgvPhong.Rows[RowEnter].Cells[1].Value.ToString();
                txtTenPhong.Text = dgvPhong.Rows[RowEnter].Cells[2].Value.ToString();
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
