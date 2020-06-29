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
    public class GheDAL
    {
        public List<GheDTO> DanhSachGhe()
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    List<PhongChieu> phongChieus = context.PhongChieus.Select(p => p).ToList();
                    List<GheDTO> ghes = new List<GheDTO>();
                    foreach (PhongChieu p in phongChieus)
                    {
                        foreach (Ghe g in p.Ghes.ToList())
                        {
                            ghes.Add(new GheDTO
                            {
                                MaGhe = g.MaGhe,
                                MaPhong = g.MaPhong,
                                TenGhe = g.TenGhe,
                                RowVersion = BitConverter.ToUInt64(g.RowVersion, 0).ToString(),
                                TenPhong = p.TenPhong
                            });
                        }
                    }
                    return ghes;
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
                    var ghe_update = context.Ghes.SingleOrDefault(p => p.MaGhe == ghe.MaGhe);
                    if (ghe_update != null)
                    {
                        if (Utils.ValidateRowversion(ghe_update.RowVersion, ghe.RowVersion))
                        {
                            foreach (var g in context.Ghes.Select(p => p).ToList())
                            {
                                if (g.MaPhong == ghe.MaPhong && g.TenGhe == ghe.TenGhe)
                                {
                                    throw new Exception($"Ghế {ghe.TenGhe} đã tồn tại trong phòng {ghe.TenPhong} rồi.");
                                }
                            }
                            ghe_update.TenGhe = ghe.TenGhe;
                            ghe_update.MaPhong = ghe.MaPhong;
                            ghe_update.NguoiSua = CurrentUser.Username;
                            ghe_update.NgaySua = DateTime.Now;
                            context.SaveChanges();
                            return true;
                        }
                        else throw new Exception("Có ai đó đã update đối tượng này trước đó. Danh sách sẽ được load lại.");
                    }
                    throw new Exception("Không tìm thấy ghế!");
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Hiện tại, có ai đó cũng đang update đối tượng này. Danh sách sẽ được load lại.");
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
                    var ghe_del = context.Ghes.SingleOrDefault(p => p.MaGhe == ghe.MaGhe);
                    if (ghe_del != null)
                    {
                        context.Ghes.Remove(ghe_del);
                        context.SaveChanges();
                        return true;
                    }
                    throw new Exception("Không tìm thấy ghế!");
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
                            throw new Exception($"Ghế {ghe.TenGhe} đã tồn tại trong phòng {ghe.TenPhong} rồi.");
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
