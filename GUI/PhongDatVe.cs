using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim.DanhSachPhong
{
    public partial class PhongDatVe : Form
    {
        LichChieuDTO lichChieu = null;
        PhongChieuDTO phongChieu = null;
        DatVeBLL datVeBLL;
        Dictionary<string, int> ghes = new Dictionary<string, int>();
        List<int> gheDaChon = new List<int>();
        List<string> gheDaDat = new List<string>();
        public PhongDatVe(LichChieuDTO lc)
        {
            InitializeComponent();
            lichChieu = lc;
            datVeBLL = new DatVeBLL();
            try
            {
                ghes = datVeBLL.LayDSGhe(lc.MaPhong);
                gheDaDat = datVeBLL.LayVeDaDat(lc.MaLichChieu);
                phongChieu = datVeBLL.LayKieuPhong(lc.MaPhong);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            // Trang : con
            // Do : da dat ve
            // Xanh la cay : da chon
            GhesDraw(gheDaDat, phongChieu.SoHang, phongChieu.SoCot);
        }
        private void GhesDraw(List<string> gheDaDat, int r, int c)
        {
            for (char i = 'A'; i < 'A' + r; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    Button b = new Button();
                    b.Text = i + "" + j;
                    b.Dock = DockStyle.Fill;
                    b.Margin = new Padding(4, 4, 4, 4);
                    b.BackColor = Color.White;
                    if (gheDaDat.Contains(b.Text))
                    {
                        b.BackColor = Color.Red;
                    }
                    b.Click += new EventHandler(button_Click);
                    GhesPanel.Controls.Add(b);
                }
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b.BackColor == Color.Red)
            {
                MessageBox.Show("Ghe da dat.");
                return;
            }
            if (b.BackColor == Color.Green)
            {
                b.BackColor = Color.White;
                return;
            }
            b.BackColor = Color.Green;
            gheDaChon.Add(ghes[b.Text]);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (datVeBLL.DatVes(gheDaChon, lichChieu.MaLichChieu))
                {
                    MessageBox.Show("Thanh cong!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
