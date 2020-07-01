using DTO;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
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
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    var list = (from pc in context.PhongChieus
                                select pc)
                               .AsEnumerable()
                               .Select(pc => new PhongChieuDTO()
                               {
                                   MaPhong = pc.MaPhong,
                                   TenPhong = pc.TenPhong,
                                   SoHang = pc.SoHang,
                                   SoCot = pc.SoCot,
                                   RowVersion = BitConverter.ToUInt64(pc.RowVersion, 0).ToString()
                               }).ToList();
                    return list;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool ThemPhong(PhongChieuDTO pc)
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    context.PhongChieus.Add(new PhongChieu()
                    {
                        MaPhong = pc.MaPhong,
                        TenPhong = pc.TenPhong,
                        SoHang = pc.SoHang,
                        SoCot = pc.SoCot,
                        NguoiTao = CurrentUser.Username,
                        NgayTao = DateTime.Now,
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

        public bool UpdatePhong(PhongChieuDTO pc)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    var phong = context.PhongChieus.SingleOrDefault(p => p.MaPhong == pc.MaPhong);
                    if (phong != null)
                    {
                        if (Utils.ValidateRowversion(phong.RowVersion, pc.RowVersion))
                        {
                            phong.TenPhong = pc.TenPhong;
                            phong.SoHang = pc.SoHang;
                            phong.SoCot = pc.SoCot;
                            phong.NguoiSua = CurrentUser.Username;
                            phong.NgaySua = DateTime.Now;
                            context.SaveChanges();
                            return true;
                        }
                        throw new Exception("Có ai đó đã update đối tượng này trước đó. Danh sách sẽ được load lại.");
                    }
                    throw new Exception("Phòng này đã bị xóa bởi ai đó. Danh sách sẽ được load lại.");
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
        public bool XoaPhong(int ma, string rv)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    var phong = context.PhongChieus.SingleOrDefault(p => p.MaPhong == ma);
                    if (phong != null)
                    {
                        if (Utils.ValidateRowversion(phong.RowVersion, rv))
                        {
                            context.PhongChieus.Remove(phong);
                            context.SaveChanges();
                            return true;
                        }
                        throw new Exception("Có ai đó đã update đối tượng này trước đó. Danh sách sẽ được load lại.");
                    }
                    throw new Exception("Phòng này đã bị xóa bởi ai đó. Danh sách sẽ được load lại.");
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
    }
}
