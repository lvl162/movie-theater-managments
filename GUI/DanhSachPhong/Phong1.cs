using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim.DanhSachPhong
{
    public partial class Phong1 : Form
    {
        Dictionary<string, PictureBox> ghes = new Dictionary<string, PictureBox>();
        public Phong1()
        {
            InitializeComponent();
            for (int i = 0; i< 3*40; i++)
            {
                var pb = new PictureBox();
                pb.Size = new Size(30, 30);
                pb.BackColor = Color.White;
                pb.Click += new EventHandler(pictureBox_Click); 
                ghes.Add($"Pic{i}", pb);
                GhesPanel.Controls.Add(pb);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            
        }
    }
}
