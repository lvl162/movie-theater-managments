using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhimDAL
    {
        public List<Phim> EF_GetAll()
        {
            using (QLRPContext context = new QLRPContext())
            {
                var list = context.Phims.Select(p => p).ToList();
                return list;
            }
        }
        public bool ThemPhim(Phim p)
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    context.Phims.Add(p);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool XoaPhim(Phim p)
        {
            using (QLRPContext context = new QLRPContext())
            {
                Phim pc = context.Phims.Single(px => px.MaPhim == p.MaPhim);
                if (pc != null)
                {
                    context.Phims.Remove(pc);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }

        }
        public bool UpdatePhim(Phim p)
        {
            using (QLRPContext context = new QLRPContext())
            {
                Phim pc = context.Phims.Single(px => px.MaPhim == p.MaPhim);
                if (pc != null)
                {
                    pc.TenPhim = p.TenPhim;
                    pc.TheLoai = p.TheLoai;
                    pc.MoTa = p.MoTa;
                    pc.NgayKhoiChieu = p.NgayKhoiChieu;
                    context.SaveChanges();
                    return true;
                }
                return false;
            }

        }
    }
}
