using DTO;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhimDAL
    {
        public List<PhimDTO> DanhSachPhim()
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    var list = context.Phims.AsEnumerable().Select(p => new PhimDTO()
                    {
                        MaPhim = p.MaPhim,
                        MoTa = p.MoTa,
                        NgayKhoiChieu = p.NgayKhoiChieu,
                        TenPhim = p.TenPhim,
                        TheLoai = p.TheLoai,
                        RowVersion = BitConverter.ToUInt64(p.RowVersion, 0).ToString()
                    })
                        .ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ThemPhim(PhimDTO p)
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    context.Phims.Add(new Phim()
                    {
                        MaPhim = p.MaPhim,
                        MoTa = p.MoTa,
                        NgayKhoiChieu = p.NgayKhoiChieu,
                        TenPhim = p.TenPhim,
                        TheLoai = p.TheLoai,
                        NgayTao = DateTime.Now,
                        NguoiTao = CurrentUser.Username,
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
        public bool XoaPhim(int ma)
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    Phim pc = context.Phims.Single(px => px.MaPhim == ma);
                    if (pc != null)
                    {
                        context.Phims.Remove(pc);
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
        public bool UpdatePhim(PhimDTO p)
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    Phim pc = context.Phims.Single(px => px.MaPhim == p.MaPhim);
                    if (pc != null)
                    {
                        if (BitConverter.ToUInt64(pc.RowVersion, 0).ToString().Equals(p.RowVersion))
                        {
                            pc.TenPhim = p.TenPhim;
                            pc.TheLoai = p.TheLoai;
                            pc.MoTa = p.MoTa;
                            pc.NgayKhoiChieu = p.NgayKhoiChieu;
                            pc.NgaySua = DateTime.Now;
                            pc.NguoiSua = CurrentUser.Username;
                            context.SaveChanges();
                            return true;
                        }
                        else throw new Exception("Có ai đó đã update đối tượng này trước đó.");
                    }
                    return false;
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Hiện tại, có ai đó cũng đang update đối tượng này.");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
