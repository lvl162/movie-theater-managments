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
    public partial class ThemUser : Form
    {
        LoginUserBLL lgBLL = new LoginUserBLL();
        int MaNV;
        public ThemUser(int maNV)
        {
            InitializeComponent();
            MaNV = maNV;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thêm tài khoản user này?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;
                    if (lgBLL.ThemUser(username, password, MaNV))
                    {
                        MessageBox.Show("Thêm thành công!");
                        Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
