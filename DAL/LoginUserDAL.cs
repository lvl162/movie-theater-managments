using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class LoginUserDAL
    {
        public List<dynamic> DanhSachUser()
        {
            using (QLRPContext context = new QLRPContext())
            {
                var list = (from lg in context.Logins
                            join nv in context.NhanViens
                            on lg.MaNhanVien equals nv.MaNhanVien
                            select new
                            {
                                UserName = lg.UserName,
                                Password = lg.Password,
                                MaNhanVien = lg.MaNhanVien,
                                HoVaTen = nv.HoVaTen,
                                ChucVu = nv.ChucVu
                            }).ToList<dynamic>();
                return list;
            }
        }

        public bool ThemUser(Login lg)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    context.Logins.Add(lg);
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
