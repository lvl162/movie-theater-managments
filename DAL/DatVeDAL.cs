using DTO;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DatVeDAL
    {
        public Dictionary<string, int> LayDSGhe(int maPhong)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    var dict = new Dictionary<string, int>();
                    List<Ghe> list = (from g in context.Ghes
                                      where g.MaPhong == maPhong
                                      select g).ToList();
                    foreach (var el in list)
                    {
                        dict.Add(el.TenGhe, el.MaGhe);
                    }
                    return dict;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<DatVeDTO> LichSuBanVe()
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    var list = context.DatVes.Select(p => p).ToList();
                    var res = new List<DatVeDTO>();
                    foreach (var el in list)
                    {
                        res.Add(new DatVeDTO()
                        {
                            TenPhim = el.LichChieu.Phim.TenPhim,
                            NgayGioChieu = el.LichChieu.NgayGioChieu,
                            TenPhong = el.LichChieu.PhongChieu.TenPhong,
                            TenGhe = el.Ghe.TenGhe,
                            NguoiBan = el.NguoiTao,
                            ThoiGianBan = el.NgayTao
                        });
                    }
                    return res;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public PhongChieuDTO LayKieuPhong(int maPhong)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    var pc = context.PhongChieus.Single(p => p.MaPhong == maPhong);
                    return new PhongChieuDTO()
                    {
                        SoCot = pc.SoCot,
                        SoHang = pc.SoHang,
                        TenPhong = pc.TenPhong,
                        MaPhong = pc.MaPhong
                    };
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<string> LayGheDaDat(int MaLichChieu)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    List<string> res = new List<string>();
                    var list = (from v in context.DatVes
                                where v.MaLichChieu == MaLichChieu
                                select v).ToList();
                    foreach (var el in list)
                    {
                        res.Add(el.Ghe.TenGhe);
                    }
                    return res;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DatVes(List<int> gheDaChon, int maLichChieu)
        {
            try
            {
                DatVe datVe;
                using (var context = new QLRPContext())
                {
                    foreach (var c in gheDaChon)
                    {
                        datVe = new DatVe()
                        {
                            MaGhe = c,
                            MaLichChieu = maLichChieu,
                            NgayTao = DateTime.Now,
                            NguoiTao = CurrentUser.Username,
                            NgaySua = DateTime.Now,
                            NguoiSua = CurrentUser.Username,
                            ThoiGianDatVe = DateTime.Now,
                        };
                        context.DatVes.Add(datVe);
                    }
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
