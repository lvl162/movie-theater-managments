using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginBLL
    {
        LoginDAL loginDAL = new LoginDAL();
        public int Login(string user, string password)
        {
            return loginDAL.Login(new Login() { UserName = user, Password = password });
        }
    }
}
