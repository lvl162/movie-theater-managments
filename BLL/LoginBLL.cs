using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BLL
{
    public class LoginBLL
    {
        LoginDAL loginDAL = new LoginDAL();
        public string Login(string user, string password)
        {
            try
            {
                return loginDAL.Login(new LoginDTO() { UserName = user, Password = password });
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
