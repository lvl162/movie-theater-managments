using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection.Emit;
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
                        if (el.MaNhanVien == lg.MaNhanVien || el.UserName == lg.UserName)
                        {
                            throw new Exception("Nhân viên này đã có tài khoản.");
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
            catch(Exception ex )
            {
                throw ex;

            }
        }

        public bool ResetPassword(LoginDTO lg)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    var login = context.Logins.Single(l => l.UserName == lg.UserName && l.MaNhanVien == lg.MaNhanVien);
                    if (login != null)
                    {
                        login.Password = Utils.HashPassword(lg.Password);
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

        public bool DeleteUser(string username, int manv)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    var login = context.Logins.Single(l => l.UserName == username && l.MaNhanVien == manv);
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
                            context.SaveChanges();
                        }
                        else throw new Exception("Có ai đó đã update đối tượng này trước đó.");
                    }
                    return true;
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Hiện tại, có ai đó cũng đang update đối tượng này.");
            }
            catch (Exception ex)
            {
                throw ex;
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
                    var nv = context.NhanViens.Single(p => p.MaNhanVien == maNV);
                    return nv.ChucVu;
                }
            }
            catch (Exception ex)
            {
                throw ex;
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

        public bool IsExists(LoginDTO loginDTO)
        {
            return Login(loginDTO) != "Khong tim thay";
        }
    }
}
