using DTO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuanLyPhimDAL
    {
        public List<PhimDTO> DanhSachPhim()
        {
            using (QLRPContext context = new QLRPContext())
            {
                var list = context.Phims.Select(p => new PhimDTO() 
                    { MaPhim = p.MaPhim,
                    MoTa = p.MoTa, NgayKhoiChieu = p.NgayKhoiChieu,
                    TenPhim = p.TenPhim, TheLoai = p.TheLoai
                    })
                    .ToList();
                return list;
            }
        }
        public bool ThemPhim(PhimDTO p)
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    context.Phims.Add(new Phim() {
                        MaPhim = p.MaPhim,
                        MoTa = p.MoTa,
                        NgayKhoiChieu = p.NgayKhoiChieu,
                        TenPhim = p.TenPhim,
                        TheLoai = p.TheLoai
                    });
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool XoaPhim(PhimDTO p)
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
        public bool UpdatePhim(PhimDTO p)
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
