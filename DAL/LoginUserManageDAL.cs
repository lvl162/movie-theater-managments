using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Model;
namespace DAL
{
    public class LoginUserManageDAL
    {
        public List<LoginUserWithNameDTO> DanhSachUser()
        {
            using (QLRPContext context = new QLRPContext())
            {
                var list = (from lg in context.Logins
                            join nv in context.NhanViens
                            on lg.MaNhanVien equals nv.MaNhanVien
                            select new LoginUserWithNameDTO()
                            {
                                UserName = lg.UserName,
                                Password = lg.Password,
                                MaNhanVien = lg.MaNhanVien,
                                HoVaTen = nv.HoVaTen,
                                ChucVu = nv.ChucVu
                            }).ToList<LoginUserWithNameDTO>();
                return list;
            }
        }

        public bool ThemUser(LoginDTO lg)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    context.Logins.Add(new Login() { MaNhanVien=lg.MaNhanVien, Password = lg.Password, UserName = lg.UserName});
                    context.SaveChanges();
                    return true;
                }
            }
            catch(Exception e )
            {
                return false;
            }
        }
    }
}
