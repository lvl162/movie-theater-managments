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
        public List<PhimDTO> LayDanhSachPhim()
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    var list = (from p in context.Phims
                                select new PhimDTO
                                {
                                    MaPhim = p.MaPhim,
                                    TenPhim = p.TenPhim,
                                    MoTa = p.MoTa,
                                    NgayKhoiChieu = p.NgayKhoiChieu,
                                    TheLoai = p.TheLoai
                                }).ToList();
                    return list;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

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

        public int getSoGheTrong(LichChieuDTO lc)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    int num_all_seats = context.Ghes.Count(p => p.MaPhong == lc.MaPhong);
                    int num_all_booked_seats = context.DatVes.Count(p => p.MaLichChieu == lc.MaLichChieu);
                    return num_all_seats - num_all_booked_seats;
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
                        context.SaveChanges();
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<LichChieuDTO> LayDanhSachLichChieuTuMaPhim(int MaPhim)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    List<LichChieuDTO> lichChieus = new List<LichChieuDTO>();
                    var list = (from p in context.LichChieus
                                where p.MaPhim == MaPhim
                                select p).ToList();
                    foreach (var lc in list)
                    {
                        lichChieus.Add(new LichChieuDTO()
                        {
                            MaPhim = lc.MaPhim,
                            MaLichChieu = lc.MaLichChieu,
                            MaPhong = lc.MaPhong,
                            NgayGioChieu = lc.NgayGioChieu,
                            TenPhim = lc.Phim.TenPhim,
                            TenPhong = lc.PhongChieu.TenPhong,
                        });
                    }
                    return lichChieus;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public PhongChieuDTO LayPhongTheoLichChieu(int MaPhong)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    PhongChieu pc = context.PhongChieus.Single(p => p.MaPhong == MaPhong);
                    return new PhongChieuDTO()
                    {
                        MaPhong = pc.MaPhong,
                        TenPhong = pc.TenPhong,
                        SoHang = pc.SoHang,
                        SoCot = pc.SoCot
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
    }
}
