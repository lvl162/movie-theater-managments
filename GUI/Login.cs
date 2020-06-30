using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim
{
    public partial class Login : Form
    {
        LoginUserBLL LoginBLL = new LoginUserBLL();
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public Login()
        {
            InitializeComponent();
            AcceptButton = loginButton;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                UserName = txtUser.Text;
                Password = txtPassword.Text;
                string ChucVu;
                /*
                QTV Hệ Thống
                Quản Lý Phòng Chiếu
                Quản Lý Phim
                Quản Lý Lịch Chiếu
                Nhân Viên Bán Vé
                */
                ChucVu = LoginBLL.Login(UserName, Password);
                if (ChucVu == "Khong tim thay")
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu..");
                }
                if (ChucVu == "QTV Hệ Thống")
                {
                    new MenuForQTV().ShowDialog();
                }
                if (ChucVu == "Nhân Viên Bán Vé")
                {
                    new NVBVForm().ShowDialog();
                }
                txtPassword.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ChangePassword().ShowDialog();
        }
    }
}
