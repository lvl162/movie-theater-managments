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
    public class QuanLyLoginBLL
    {
        QuanLyLoginDAL loginDAL = new QuanLyLoginDAL();
        public string Login(string user, string password)
        {
            return loginDAL.Login(new LoginDTO() { UserName = user, Password = password });
        }
    }
}
