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
                    context.Logins.Add(new Login() { MaNhanVien=lg.MaNhanVien, Password = lg.Password, UserName = lg.UserName, NgayTao = DateTime.Now, NguoiTao = CurrentUser.Username});
                    context.SaveChanges();
                    return true;
                }
            }
            catch(Exception e )
            {
                return false;
            }
        }
        public bool UpdateUser(LoginDTO lg)
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    Login login = context.Logins.Single(p => p.UserName == lg.UserName && p.MaNhanVien == lg.MaNhanVien);
                    if (login!= null)
                    {
                        login.MaNhanVien = lg.MaNhanVien;
                        login.NgaySua = DateTime.Now;
                        login.NguoiSua = CurrentUser.Username;
                        login.Password = lg.Password;
                        login.UserName = lg.UserName;
                        context.SaveChanges();
                    }
                    return true;

                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
