using DTO;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    //Thao tác với CSDL

    public class PhongChieuDAL
    {
        public List<PhongChieuDTO> DanhSachPhongChieu()
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    var list = (from pc in context.PhongChieus
                                select pc)
                               .AsEnumerable()
                               .Select (pc => new PhongChieuDTO() { 
                        MaPhong = pc.MaPhong, TenPhong = pc.TenPhong, SoGhe = pc.SoGhe, RowVersion = BitConverter.ToUInt64(pc.RowVersion, 0).ToString()
                    }).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ThemPhong(PhongChieuDTO pc)
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    context.PhongChieus.Add(new PhongChieu() { MaPhong = pc.MaPhong, TenPhong = pc.TenPhong,
                        SoGhe = pc.SoGhe, NguoiTao = CurrentUser.Username, NgayTao = DateTime.Now,
                        NgaySua = DateTime.Now,
                        NguoiSua = CurrentUser.Username
                    });
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool UpdatePhong(PhongChieuDTO pc)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    var phong = context.PhongChieus.Single(p => p.MaPhong == pc.MaPhong);
                    if (phong != null)
                    {
                        if (BitConverter.ToUInt64(phong.RowVersion, 0).ToString().Equals(pc.RowVersion))
                        {
                            phong.TenPhong = pc.TenPhong;
                            phong.SoGhe = pc.SoGhe;
                            phong.NguoiSua = CurrentUser.Username;
                            phong.NgaySua = DateTime.Now;
                            context.SaveChanges();
                            return true;
                        }
                        else throw new Exception("Da co update truoc do.");
                    }
                    return false;
                }
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new Exception("Update failed. Ai do cung dang up");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool XoaPhong(PhongChieuDTO pc)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    var phong = context.PhongChieus.Single(p => p.MaPhong == pc.MaPhong);
                    if (phong != null)
                    {
                        context.PhongChieus.Remove(phong);
                        context.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
