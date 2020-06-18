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
        QuanLyLoginBLL LoginBLL = new QuanLyLoginBLL();
        public Login()
        {
            InitializeComponent();
            AcceptButton = loginButton;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUser.Text;
                string password = txtPassword.Text;
                string ChucVu;
                /*
                QTV Hệ Thống
                Quản Lý Phòng Chiếu
                Quản Lý Phim
                Quản Lý Lịch Chiếu
                Nhân Viên Bán Vé
                */
                ChucVu = LoginBLL.Login(username, password);
                if (ChucVu == "Khong tim thay")
                {
                    MessageBox.Show("Sai ten dang nhap/ mat khau..");
                    //new QuanLyNhanVien().ShowDialog();
                }
                if (ChucVu == "QTV Hệ Thống")
                {
                    new QuanLyNhanVien().ShowDialog();
                }
                if (ChucVu == "Quản Lý Phim")
                {
                    new QuanLyPhim().ShowDialog();
                }
                if (ChucVu == "Quản Lý Phòng Chiếu")
                {
                    new QuanLyPhong().ShowDialog();
                }
                if (ChucVu == "Nhân Viên Bán Vé")
                {
                    new DatVe().ShowDialog();
                }
                if (ChucVu == "Quản Lý Lịch Chiếu")
                {
                    new QuanLyLichChieu().ShowDialog();
                }
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
    }
}
