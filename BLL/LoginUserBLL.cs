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
    public class LoginUserBLL
    {
        LoginUserDAL userDAL = new LoginUserDAL();
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

        public bool UpdateUser(string new_user, string new_password, int new_manv, string old_user, int old_manv, string rowVer)
        {
            try
            {
                if (userDAL.UpdateUser(new LoginDTO() { UserName = new_user, Password = new_password, MaNhanVien = new_manv, RowVersion = rowVer },old_user, old_manv))
                    return true;
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
