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
    public partial class ResetPassword : Form
    {
        LoginUserBLL lgBLL = new LoginUserBLL();
        int MaNV;
        public ResetPassword(string username, int manv)
        {
            InitializeComponent();
            txtUsername.Text = username;
            txtUsername.ReadOnly = true;
            MaNV = manv;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string new_pw = txtNewPass.Text;
                string con_pw = txtConfirmPass.Text;
                if (new_pw != con_pw || new_pw == "")
                {
                    throw new Exception("Mật khẩu mới không trùng khớp hoặc còn trống.");
                }
                else
                {
                    if (lgBLL.ResetPassword(txtUsername.Text, new_pw, MaNV))
                    {
                        MessageBox.Show("Reset mật khẩu thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
