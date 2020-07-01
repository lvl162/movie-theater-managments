using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim
{
    public partial class QuanLyLichChieu : Form
    {
        LichChieuBLL lichChieuBLL;
        int RowEnter = 0;
        List<LichChieuDTO> list = new List<LichChieuDTO>();
        public QuanLyLichChieu()
        {
            InitializeComponent();
            lbHi.Text = $"Hi {Login.UserName}!";
            lichChieuBLL = new LichChieuBLL();
            dgvDSLichChieu.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm tt";
            dgvDSLichChieu.AutoGenerateColumns = false;
            cbOptions.SelectedIndex = 0;
            pbPoster.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void QuanLyLichChieu_Load(object sender, EventArgs e)
        {
            try
            {
                list = lichChieuBLL.DanhSachLichChieu();
                dgvDSLichChieu.DataSource = list;
                cbPhims.DataSource = lichChieuBLL.getPhims();
                cbPhims.DisplayMember = "TenPhim";
                cbPhims.ValueMember = "MaPhim";
                cbPhongs.DataSource = lichChieuBLL.getPhongs();
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
                    int maPhim;
                    int maPhong;
                    DateTime gioLichChieu;
                    maPhim = int.Parse(cbPhims.SelectedValue.ToString());
                    maPhong = int.Parse(cbPhongs.SelectedValue.ToString());
                    gioLichChieu = lichChieuPicker.Value;
                    if (lichChieuBLL.ThemLichChieu(maPhim, maPhong, gioLichChieu))
                    {
                        MessageBox.Show("Thêm thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                QuanLyLichChieu_Load(sender, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn sửa?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    int malc_old = int.Parse(dgvDSLichChieu.Rows[RowEnter].Cells[0].Value.ToString());
                    int maPhim;
                    int maPhong;
                    DateTime gioLichChieu;
                    maPhim = int.Parse(cbPhims.SelectedValue.ToString());
                    maPhong = int.Parse(cbPhongs.SelectedValue.ToString());
                    gioLichChieu = lichChieuPicker.Value;
                    string rowVer = dgvDSLichChieu.Rows[RowEnter].Cells[4].Value.ToString();
                    if (lichChieuBLL.UpdateLichChieu(maPhim, maPhong, gioLichChieu, malc_old, rowVer))
                    {
                        MessageBox.Show("Update thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                QuanLyLichChieu_Load(sender, e);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    int malc_delete = int.Parse(dgvDSLichChieu.Rows[RowEnter].Cells[0].Value.ToString());
                    string rowVer = dgvDSLichChieu.Rows[RowEnter].Cells[4].Value.ToString();

                    if (lichChieuBLL.XoaLichChieu(malc_delete, rowVer))
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                QuanLyLichChieu_Load(sender, e);
            }
        }

        private void dgvDSLichChieu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RowEnter = e.RowIndex;
                cbPhims.SelectedValue = dgvDSLichChieu.Rows[RowEnter].Cells[2].Value;
                cbPhongs.SelectedValue = dgvDSLichChieu.Rows[RowEnter].Cells[1].Value;
                lichChieuPicker.Value = DateTime.Parse(dgvDSLichChieu.Rows[RowEnter].Cells[3].Value.ToString());
                string picPath = Utils.projectDirectory + dgvDSLichChieu.Rows[RowEnter].Cells[7].Value.ToString();
                pbPoster.Image = Image.FromFile(picPath);
            }
            catch (FileNotFoundException)
            {
                pbPoster.Image = Image.FromFile(Utils.projectDirectory + "notfound.jpg");
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = cbOptions.SelectedIndex;
                string text = txtSearch.Text.ToLower();
                if (index == 0)
                {
                    dgvDSLichChieu.DataSource = list.Where(p => Utils.convertToUnSign(p.TenPhim).ToLower().Contains(text)|| p.TenPhim.ToLower().Contains(text)).ToList();
                }
                if (index == 1)
                {
                    dgvDSLichChieu.DataSource = list.Where(p => p.TenPhong.ToLower().Contains(text)).ToList();
                }
                if (index == 2)
                {
                    dgvDSLichChieu.DataSource = list.Where(p => p.NgayChieu.Contains(text) || p.GioChieu.Contains(text)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            QuanLyLichChieu_Load(sender, e);
        }
    }
}
