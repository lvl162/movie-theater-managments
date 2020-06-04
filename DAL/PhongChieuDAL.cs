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
        public List<PhongChieu> EF_GetAll()
        {
            QLRPContext context = new QLRPContext();
            var list = context.PhongChieus.Select(p => p).ToList();
            return list;
        }
        public bool ThemPhong(PhongChieu pc)
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    context.PhongChieus.Add(pc);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool UpdatePhong(PhongChieu pc)
        {
            using (var context = new QLRPContext())
            {
                var phong = context.PhongChieus.Single(p => p.MaPhong == pc.MaPhong);
                if (phong != null)
                {
                    phong.DienTich = pc.DienTich;
                    phong.SoGhe = pc.SoGhe;
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public bool XoaPhong(PhongChieu pc)
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
