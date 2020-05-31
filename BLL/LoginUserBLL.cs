using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace BLL
{
    public class LoginUserBLL
    {
        LoginUserDAL userDAL = new LoginUserDAL();
        public void DanhSachUser(DataGridView dgv)
        {
            dgv.DataSource = userDAL.DanhSachUser();
        }
        public bool ThemUser(string username, string password, int maNV)
        {
            if (userDAL.ThemUser(new Login() { UserName = username, Password = password, MaNhanVien = maNV})) return true;
            return false;
        }
    }
}
