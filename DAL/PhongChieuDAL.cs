using DTO;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
            QLRPContext context = new QLRPContext();
            var list = context.PhongChieus.Select(pc => new PhongChieuDTO() { MaPhong = pc.MaPhong, TenPhong = pc.TenPhong, SoGhe = pc.SoGhe }).ToList();
            return list;
        }
        public bool ThemPhong(PhongChieuDTO pc)
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    context.PhongChieus.Add(new PhongChieu() { MaPhong = pc.MaPhong, TenPhong = pc.TenPhong, SoGhe = pc.SoGhe });
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool UpdatePhong(PhongChieuDTO pc)
        {
            using (var context = new QLRPContext())
            {
                var phong = context.PhongChieus.Single(p => p.MaPhong == pc.MaPhong);
                if (phong != null)
                {
                    phong.TenPhong = pc.TenPhong;
                    phong.SoGhe = pc.SoGhe;
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public bool XoaPhong(PhongChieuDTO pc)
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
    }
}
