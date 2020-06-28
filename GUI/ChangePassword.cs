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
    public partial class ChangePassword : Form
    {
        LoginUserBLL loginBLL = new LoginUserBLL();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUsername.Text;
                string oldPassword = txtOldPass.Text;
                string newPassword = txtNewPass.Text;
                string confirmPassword = txtConfirmPass.Text;
                if (newPassword != confirmPassword || newPassword == "")
                {
                    throw new Exception("Mật khẩu mới không trùng khớp hoặc còn trống.");
                }
                if (!loginBLL.IsExists(userName, oldPassword))
                {
                    throw new Exception("Username hoặc mật khẩu không đúng hoặc còn trống.");
                }
                if (loginBLL.ChangePassword(userName, oldPassword, newPassword)) {
                    MessageBox.Show("Đổi mật khẩu thành công!");
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
