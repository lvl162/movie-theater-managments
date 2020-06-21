using DTO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GheDAL
    {
        public List<GheDTO> DanhSachGhe()
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    List<PhongChieu> list2 = context.PhongChieus.Select(p => p).ToList();
                    List<GheDTO> list3 = new List<GheDTO>();
                    foreach (PhongChieu p in list2)
                    {
                        List<Ghe> ghes = p.Ghes.ToList();
                        foreach (Ghe g in ghes)
                        {
                            list3.Add(new GheDTO
                            {
                                MaGhe = g.MaGhe,
                                MaPhong = g.MaPhong,
                                TenGhe = g.TenGhe,
                                RowVersion = BitConverter.ToUInt64(g.RowVersion, 0).ToString(),
                                TenPhong = p.TenPhong
                            });
                        }
                    }
                    return list3;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool UpdateGhe(GheDTO ghe)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    var ghe_update = context.Ghes.Single(p => p.MaGhe == ghe.MaGhe);
                    if (ghe != null)
                    {
                        if (BitConverter.ToUInt64(ghe_update.RowVersion, 0).ToString().Equals(ghe.RowVersion))
                        {
                            foreach (var g in context.Ghes.Select(p => p).ToList())
                            {
                                if (g.MaPhong == ghe.MaPhong && g.TenGhe == ghe.TenGhe)
                                {
                                    throw new Exception($"Ghe {ghe.TenGhe} da ton tai trong phong {ghe.TenPhong}");
                                }
                            }
                            ghe_update.TenGhe = ghe.TenGhe;
                            ghe_update.MaPhong = ghe.MaPhong;
                            ghe_update.NguoiSua = CurrentUser.Username;
                            ghe_update.NgaySua = DateTime.Now;
                            context.SaveChanges();
                            return true;
                        }
                        else throw new Exception("Da co update truoc do.");
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool XoaGhe(GheDTO ghe)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    var ghe_del = context.Ghes.Single(p => p.MaGhe == ghe.MaGhe);
                    if (ghe_del != null)
                    {
                        context.Ghes.Remove(ghe_del);
                        context.SaveChanges();
                        return true;
                    }
                    throw new Exception("Khong tim thay ghe!");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool ThemGhe(GheDTO ghe)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    foreach (var g in context.Ghes.Select(p=>p).ToList())
                    {
                        if (g.MaPhong == ghe.MaPhong && g.TenGhe == ghe.TenGhe)
                        {
                            throw new Exception($"Ghe {ghe.TenGhe} da ton tai trong phong {ghe.TenPhong}");
                        }
                    }
                    context.Ghes.Add(new Ghe
                    {
                        TenGhe = ghe.TenGhe,
                        NgayTao = DateTime.Now,
                        NguoiTao = CurrentUser.Username,
                        NgaySua = DateTime.Now,
                        NguoiSua = CurrentUser.Username,
                        MaPhong = ghe.MaPhong
                    });
                    context.SaveChanges();
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
