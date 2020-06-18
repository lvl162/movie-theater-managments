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
        public List<LoginUserWithNameDTO> DanhSachUser()
        {
            try
            {
                return userDAL.DanhSachUser();
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }
        public bool ThemUser(string username, string password, int maNV)
        {
            try
            {
                if (userDAL.ThemUser(new LoginDTO() { UserName = username, Password = password, MaNhanVien = maNV })) return true;
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
