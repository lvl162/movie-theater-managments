using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Model;
namespace DAL
{
    public class LoginUserDAL
    {
        public bool ThemUser(LoginDTO lg)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    foreach (var el in context.Logins.Select(p=>p).ToList())
                    {
                        if (el.MaNhanVien == lg.MaNhanVien)
                        {
                            throw new Exception("Nhân viên này đã có tài khoản.");
                        }
                        if (el.UserName == lg.UserName)
                        {
                            throw new Exception("Username này đã tồn tại. Xin thử lại!");
                        }
                    }
                    Login newLogin = new Login()
                    {
                        MaNhanVien = lg.MaNhanVien,
                        Password = Utils.HashPassword(lg.Password),
                        UserName = lg.UserName,
                        NgayTao = DateTime.Now,
                        NguoiTao = CurrentUser.Username,
                        NgaySua = DateTime.Now,
                        NguoiSua = CurrentUser.Username
                    };
                    context.Logins.Add(newLogin);
                    context.SaveChanges();
                    return true;
                }
            }
            catch(Exception)
            {
                throw;

            }
        }

        public bool ResetPassword(LoginDTO lg)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    var login = context.Logins.SingleOrDefault(l => l.UserName == lg.UserName && l.MaNhanVien == lg.MaNhanVien);
                    if (login != null)
                    {
                        login.Password = Utils.HashPassword(lg.Password);
                        login.NguoiSua = CurrentUser.Username;
                        login.NgaySua = DateTime.Now;
                        context.SaveChanges();
                        return true;
                    }
                    throw new Exception("User này đã bị xóa bởi ai đó.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteUser(int manv)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    var login = context.Logins.SingleOrDefault(l => l.MaNhanVien == manv);
                    if (login != null)
                    {
                        context.Logins.Remove(login);
                        context.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Login(LoginDTO lg)
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    Login res = context.Logins.AsEnumerable().SingleOrDefault(l => l.UserName == lg.UserName && Utils.ValidatePassword(lg.Password, l.Password));
                    if (res == null) { return "Khong tim thay"; }
                    int maNV = res.MaNhanVien;
                    CurrentUser.Username = res.UserName;
                    CurrentUser.Password = res.Password;
                    var nv = context.NhanViens.SingleOrDefault(p => p.MaNhanVien == maNV);
                    return nv.ChucVu;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ChangePassword(LoginDTO lg, string newPassword)
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    Login res = context.Logins.AsEnumerable().SingleOrDefault(l => l.UserName == lg.UserName 
                    && Utils.ValidatePassword(lg.Password, l.Password));
                    if (res != null)
                    {
                        res.Password = Utils.HashPassword(newPassword);
                        res.NgaySua = DateTime.Now;
                        res.NguoiSua = res.UserName;
                        context.SaveChanges();
                        return true;
                    }
                    throw new Exception("Không tìm thấy tài khoản.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool IsExists(LoginDTO loginDTO)
        {
            return Login(loginDTO) != "Khong tim thay";
        }
    }
}
