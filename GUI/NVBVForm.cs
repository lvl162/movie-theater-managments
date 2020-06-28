using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim
{
    public partial class NVBVForm : Form
    {
        int RowEnter = 0;
        public static string posterPath;
        public NVBVForm()
        {
            InitializeComponent();
            pbPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            list = lichChieuBLL.DanhSachLichChieu();
            dgvLichChieu.AutoGenerateColumns = false;
            cbOptions.SelectedIndex = 0;
        }
        LichChieuBLL lichChieuBLL = new LichChieuBLL();
        List<LichChieuDTO> list = new List<LichChieuDTO>();
        private void LichChieu_Load(object sender, EventArgs e)
        {
            try
            {
                list = lichChieuBLL.DanhSachLichChieu();
                dgvLichChieu.DataSource = list;
                cbOptions.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            LichChieuDTO lc = dgvLichChieu.CurrentRow.DataBoundItem as LichChieuDTO;
            new BanVe(lc).ShowDialog();
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
                txtGheTrong.Text = dgvLichChieu.Rows[RowEnter].Cells[7].Value + "";
                posterPath = Utils.projectDirectory + dgvLichChieu.Rows[RowEnter].Cells[6].Value.ToString().Trim();
                pbPoster.Image = Image.FromFile(posterPath);
            }
            catch (FileNotFoundException)
            {
                posterPath = Utils.projectDirectory + "notfound.jpg";
                pbPoster.Image = Image.FromFile(posterPath);
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
                int index = cbOptions.SelectedIndex;
                string text = txtSearch.Text.ToLower();
                if (index == 0)
                {
                    dgvLichChieu.DataSource = list.Where(p => Utils.convertToUnSign(p.TenPhim).ToLower().Contains(text)).ToList();
                }
                if (index == 1)
                {
                    dgvLichChieu.DataSource = list.Where(p => p.NgayChieu.Contains(text)).ToList();
                }
                if (index == 2)
                {
                    dgvLichChieu.DataSource = list.Where(p => p.GioChieu.Contains(text)).ToList();
                }
                if (index == 3)
                {
                    dgvLichChieu.DataSource = list.Where(p => p.TenPhong.ToLower().Contains(text)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            new LichSuBanVe().ShowDialog();
        }

        private void cbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
