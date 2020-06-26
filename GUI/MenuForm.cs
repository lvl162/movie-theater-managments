using GUI;
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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            new DatVe().ShowDialog();
        }

        private void btnQLPhong_Click(object sender, EventArgs e)
        {
            new QuanLyPhong().ShowDialog();
        }

        private void btnQLPhim_Click(object sender, EventArgs e)
        {
            new QuanLyPhim().ShowDialog();
        }

        private void btnQLLichChieu_Click(object sender, EventArgs e)
        {
            new QuanLyLichChieu().ShowDialog();
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            new QuanLyNhanVien().ShowDialog();
        }

        private void btnQLUser_Click(object sender, EventArgs e)
        {
            new QuanLyLoginUser().ShowDialog();
        }
    }
}
