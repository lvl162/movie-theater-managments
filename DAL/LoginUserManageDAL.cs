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
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    var list = (from lg in context.Logins.AsEnumerable()
                                join nv in context.NhanViens.AsEnumerable()
                                on lg.MaNhanVien equals nv.MaNhanVien
                                select new LoginUserWithNameDTO()
                                {
                                    UserName = lg.UserName,
                                    Password = lg.Password,
                                    MaNhanVien = lg.MaNhanVien,
                                    HoVaTen = nv.HoVaTen,
                                    ChucVu = nv.ChucVu,
                                    RowVersion = BitConverter.ToUInt64(lg.RowVersion, 0).ToString()
                                }).ToList<LoginUserWithNameDTO>();
                    return list;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public bool ThemUser(LoginDTO lg)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    context.Logins.Add(new Login() { MaNhanVien=lg.MaNhanVien, Password = lg.Password, 
                        UserName = lg.UserName, NgayTao = DateTime.Now, NguoiTao = CurrentUser.Username,
                        NgaySua = DateTime.Now,
                        NguoiSua = CurrentUser.Username
                    });
                    context.SaveChanges();
                    return true;
                }
            }
            catch(Exception ex )
            {
                throw ex;

            }
        }
        public bool UpdateUser(LoginDTO lg, string old_user, int old_manv)
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    Login login = context.Logins.Single(p => p.UserName == old_user && p.MaNhanVien == old_manv);
                    if (login!= null)
                    {
                        if (BitConverter.ToUInt64(login.RowVersion, 0).ToString().Equals(lg.RowVersion))
                        {
                            login.MaNhanVien = lg.MaNhanVien;
                            login.NgaySua = DateTime.Now;
                            login.NguoiSua = CurrentUser.Username;
                            login.Password = lg.Password;
                            login.UserName = lg.UserName;
                            //TODO: The property '' is part of the object's key information and cannot be modified
                            context.SaveChanges();
                        }
                        else throw new Exception("Da co update truoc do.");
                    }
                    return true;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
