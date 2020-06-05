using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Model;
namespace DAL
{
    public class LoginDAL
    {
        public string Login(LoginDTO lg)
        {
            using(QLRPContext context = new QLRPContext())
            {
                try
                {
                    //Login res = context.Logins.Single(p => p.UserName == lg.UserName && p.Password == lg.Password);
                    LoginDTO res = (from l in context.Logins
                                    where l.UserName == lg.UserName && l.Password == lg.Password
                                    select new LoginDTO
                                    {
                                        MaNhanVien = l.MaNhanVien,
                                        UserName = l.UserName,
                                        Password = l.Password
                                    }).SingleOrDefault();
                    if (res == null) { throw new Exception("Khong tim thay"); }
                    int maNV = res.MaNhanVien;
                    var nv = context.NhanViens.Single(p => p.MaNhanVien == maNV);
                    
                    return nv.ChucVu;
                }
                catch (Exception e) { return "Khong tim thay"; }
                
            }
        }
    }
}
