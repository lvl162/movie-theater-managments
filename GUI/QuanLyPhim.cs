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
using BLL;
namespace QuanLyRapPhim
{
    public partial class QuanLyPhim : Form
    {
        PhimBLL phimBLL;
        int RowEnter = 0;
        static string workingDirectory = Environment.CurrentDirectory;
        static string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\PhimPosters\";
        public QuanLyPhim()
        {
            InitializeComponent();
            lbHi.Text = $"Hi {Login.UserName}!";
            phimBLL = new PhimBLL();
            dgvPhim.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            pbPoster.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void QuanLyPhim_Load(object sender, EventArgs e)
        {
            try
            {
                dgvPhim.AutoGenerateColumns = false;
                dgvPhim.DataSource = phimBLL.DanhSachPhim();
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
                    string tenPhim, theLoai, moTa;
                    DateTime khoiChieu;
                    tenPhim = txtTenPhim.Text;
                    theLoai = txtTheLoai.Text;
                    moTa = txtTenPhim.Text +".jpg";
                    khoiChieu = timePickerKhoiChieu.Value.Date;
                    if (phimBLL.ThemPhim(tenPhim, theLoai, khoiChieu, moTa))
                    {
                        MessageBox.Show("Thêm thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                QuanLyPhim_Load(sender, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn sửa?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    string tenPhim, theLoai, moTa;
                    int maPhim = int.Parse(dgvPhim.Rows[RowEnter].Cells[0].Value.ToString());
                    DateTime khoiChieu;
                    tenPhim = txtTenPhim.Text;
                    theLoai = txtTheLoai.Text;
                    moTa = txtTenPhim.Text + ".jpg";
                    khoiChieu = timePickerKhoiChieu.Value.Date;
                    string rowVer = dgvPhim.Rows[RowEnter].Cells[5].Value.ToString();
                    if (phimBLL.UpdatePhim(maPhim, tenPhim, theLoai, khoiChieu, moTa, rowVer))
                        MessageBox.Show("Update thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                QuanLyPhim_Load(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    int maPhim = int.Parse(dgvPhim.Rows[RowEnter].Cells[0].Value.ToString());
                    
                    if (phimBLL.XoaPhim(maPhim))
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                QuanLyPhim_Load(sender, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                txtTenPhim.Text = dgvPhim.Rows[RowEnter].Cells[1].Value.ToString();
                txtTheLoai.Text = dgvPhim.Rows[RowEnter].Cells[2].Value.ToString();
                timePickerKhoiChieu.Value = DateTime.Parse(dgvPhim.Rows[RowEnter].Cells[3].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPhim_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RowEnter = e.RowIndex;
                txtTenPhim.Text = dgvPhim.Rows[RowEnter].Cells[1].Value.ToString();
                txtTheLoai.Text = dgvPhim.Rows[RowEnter].Cells[2].Value.ToString();
                timePickerKhoiChieu.Value = DateTime.Parse(dgvPhim.Rows[RowEnter].Cells[3].Value.ToString());
                string picPath = projectDirectory + dgvPhim.Rows[RowEnter].Cells[4].Value.ToString();
                pbPoster.Image = Image.FromFile(picPath);
            }
            catch(FileNotFoundException)
            {
                pbPoster.Image = Image.FromFile(projectDirectory + "notfound.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
