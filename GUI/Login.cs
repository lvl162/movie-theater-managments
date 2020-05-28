using BLL;
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
    public partial class Login : Form
    {
        LoginBLL LoginBLL = new LoginBLL();
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;
            int role;
            role = LoginBLL.Login(username, password);
            if (role == -1)
            {
                MessageBox.Show("Sai ten dang nhap/ mat khau..");
            }
            if (role == 1)
            {
                new QuanLyNhanVien().ShowDialog();
            }
            if (role == 2)
            {
                new QuanLyPhim().ShowDialog();
            }
            if (role == 3)
            {
                new QuanLyPhong().ShowDialog();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new QuanLyPhim().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new QuanLyPhong().ShowDialog();
        }
    }
}
