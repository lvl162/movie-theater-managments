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
    public partial class QuanLyLichChieu : Form
    {
        QuanLyLichChieuBLL lichChieuBLL;
        public QuanLyLichChieu()
        {
            InitializeComponent();
            lichChieuBLL = new QuanLyLichChieuBLL();
        }

        private void QuanLyLichChieu_Load(object sender, EventArgs e)
        {
            try
            {
                //dgvDSLichChieu.AutoGenerateColumns = false;
                dgvDSLichChieu.DataSource = lichChieuBLL.DanhSachLichChieu();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
