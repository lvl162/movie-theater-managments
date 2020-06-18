using DTO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public List<LichChieuDTO> LayDanhSachLichChieuTuMaPhim(int MaPhim)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    var list = (from p in context.LichChieus
                                where p.MaPhim == MaPhim
                                select new LichChieuDTO()
                                {
                                    MaPhim = p.MaPhim,
                                    MaLichChieu = p.MaLichChieu,
                                    MaPhong = p.MaPhong,
                                    NgayGioChieu = p.NgayGioChieu
                                }).ToList();
                    return list;
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
                        SoGhe = pc.SoGhe
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
