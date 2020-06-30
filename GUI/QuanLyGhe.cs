using BLL;
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

namespace QuanLyRapPhim
{
    public partial class QuanLyGhe : Form
    {
        GheBLL gheBLL;
        int RowEnter = 0;
        public QuanLyGhe()
        {
            InitializeComponent();
            lbHi.Text = $"Hi {Login.UserName}!";
            gheBLL = new GheBLL();
        }
        private void QuanLyGhe_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDSGhe.AutoGenerateColumns = false;
                dgvDSGhe.DataSource = gheBLL.DanhSachGhe();
                cbPhongs.DataSource = gheBLL.DanhSachPhong();
                cbPhongs.DisplayMember = "TenPhong";
                cbPhongs.ValueMember = "MaPhong";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thêm?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    string tenghe = txtTenGhe.Text;
                    int maphong = int.Parse(cbPhongs.SelectedValue.ToString());
                    string tenPhong = dgvDSGhe.Rows[RowEnter].Cells[3].Value.ToString();
                    if (gheBLL.ThemGhe(tenghe, maphong, tenPhong))
                        MessageBox.Show("Thêm thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                QuanLyGhe_Load(sender, e);
            }    
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn cập nhật?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    int maGhe = int.Parse(dgvDSGhe.Rows[RowEnter].Cells[0].Value.ToString());
                    string tenGhe = txtTenGhe.Text;
                    int maPhong = int.Parse(cbPhongs.SelectedValue.ToString());
                    string rowVersion = dgvDSGhe.Rows[RowEnter].Cells[4].Value.ToString();
                    if (gheBLL.UpdateGhe(maGhe, tenGhe, maPhong, rowVersion))
                    {
                        MessageBox.Show("Update thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                QuanLyGhe_Load(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    int maGhe = int.Parse(dgvDSGhe.Rows[RowEnter].Cells[0].Value.ToString());
                    int maPhong = int.Parse(dgvDSGhe.Rows[RowEnter].Cells[2].Value.ToString());
                    string tenGhe = txtTenGhe.Text;

                    if (gheBLL.XoaGhe(maGhe, tenGhe, maPhong))
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                QuanLyGhe_Load(sender, e);
            }
            
        }

        private void dgvDSGhe_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RowEnter = e.RowIndex;
                txtTenGhe.Text = dgvDSGhe.Rows[RowEnter].Cells[1].Value.ToString();
                cbPhongs.Text = dgvDSGhe.Rows[RowEnter].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            QuanLyGhe_Load(sender, e);
        }
    }
}
