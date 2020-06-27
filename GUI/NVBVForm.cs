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
        static string workingDirectory = Environment.CurrentDirectory;
        static string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\PhimPosters\";
        public NVBVForm()
        {
            InitializeComponent();
            pbPoster.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        LichChieuBLL lichChieuBLL = new LichChieuBLL();

        private void LichChieu_Load(object sender, EventArgs e)
        {
            try
            {
                dgvLichChieu.AutoGenerateColumns = false;
                dgvLichChieu.DataSource = lichChieuBLL.DanhSachLichChieu();
                txtSearch.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            LichChieuDTO lc = dgvLichChieu.CurrentRow.DataBoundItem as LichChieuDTO;
            new DatVe(lc).ShowDialog();
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
                string picPath = dgvLichChieu.Rows[RowEnter].Cells[6].Value.ToString().Trim();
                pbPoster.Image = Image.FromFile(projectDirectory + picPath);
            }
            catch (FileNotFoundException)
            {
                pbPoster.Image = Image.FromFile(projectDirectory + "notfound.jpg");
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

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            new LichSuBanVe().ShowDialog();
        }
    }
}
