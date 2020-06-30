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
        public string Login(string user, string password)
        {
            try
            {
                return userDAL.Login(new LoginDTO() { UserName = user, Password = password });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool IsExists(string userName, string oldPassword)
        {
            try
            {
                return userDAL.IsExists(new LoginDTO() { UserName = userName, Password = oldPassword });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ChangePassword(string userName, string oldPassword, string newPassword)
        {
            try
            {
                return userDAL.ChangePassword(new LoginDTO() { UserName = userName, Password = oldPassword }, newPassword);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ResetPassword(string username, string new_pw, int manv)
        {
            try
            {
                return userDAL.ResetPassword(new LoginDTO() { UserName = username, Password = new_pw, MaNhanVien = manv });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ThemUser(string username, string password, int maNV)
        {
            try
            {
                return userDAL.ThemUser(new LoginDTO() { UserName = username, Password = password, MaNhanVien = maNV });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
