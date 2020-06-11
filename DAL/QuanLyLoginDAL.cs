﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Model;
namespace DAL
{
    public static class CurrentUser
    {
        public static string Username;
        public static string Password;
    }
    public class QuanLyLoginDAL
    {
        public string Login(LoginDTO lg)
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
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
                    CurrentUser.Username = res.UserName;
                    CurrentUser.Password = res.Password;
                    var nv = context.NhanViens.Single(p => p.MaNhanVien == maNV);

                    return nv.ChucVu;
                }
            }
            catch (Exception ex)
            {
                return "Khong tim thay";
            }
        }

    }
}
