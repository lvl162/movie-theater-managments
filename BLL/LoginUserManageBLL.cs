using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using Model;

namespace BLL
{
    public class LoginUserManageBLL
    {
        LoginUserManageDAL userDAL = new LoginUserManageDAL();
        public void DanhSachUser(DataGridView dgv)
        {
            dgv.DataSource = userDAL.DanhSachUser();
        }
        public bool ThemUser(string username, string password, int maNV)
        {
            if (userDAL.ThemUser(new LoginDTO() { UserName = username, Password = password, MaNhanVien = maNV})) return true;
            return false;
        }
    }
}
