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
    public class NhanVienDAL
    {
        public bool ThemNhanVien(NhanVienDTO nv)
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    context.NhanViens.Add(new NhanVien() { 
                    MaNhanVien = nv.MaNhanVien,
                    ChucVu = nv.ChucVu,
                    NgaySinh = nv.NgaySinh,
                    DiaChi = nv.DiaChi,
                    GioiTinh = nv.GioiTinh,
                    HoVaTen = nv.HoVaTen,
                    SDT = nv.SDT,
                    SoCMND = nv.SoCMND,
                    NgayTao = DateTime.Now,
                    NguoiTao = CurrentUser.Username,
                    NgaySua = DateTime.Now,
                    NguoiSua = CurrentUser.Username
                    });
                    context.SaveChanges();
                    return true;
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public bool XoaNhanVien(int manv)
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    NhanVien nv_found = context.NhanViens.Single(p => p.MaNhanVien == manv);
                    if (nv_found != null)
                    {
                        context.NhanViens.Remove(nv_found);
                        context.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool UpdateNhanVien(NhanVienDTO nv)
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    NhanVien nv_found = context.NhanViens.Single(p => p.MaNhanVien == nv.MaNhanVien);
                    if (nv_found != null)
                    {
                        if (BitConverter.ToUInt64(nv_found.RowVersion, 0).ToString().Equals(nv.RowVersion))
                        {
                            nv_found.ChucVu = nv.ChucVu;
                            nv_found.DiaChi = nv.DiaChi;
                            nv_found.HoVaTen = nv.HoVaTen;
                            nv_found.NgaySinh = nv.NgaySinh;
                            nv_found.SDT = nv.SDT;
                            nv_found.SoCMND = nv.SoCMND;
                            nv_found.GioiTinh = nv.GioiTinh;
                            nv_found.NguoiSua = CurrentUser.Username;
                            nv_found.NgayTao = DateTime.Now;
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
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<NhanVienDTO> DanhSachSinhVien()
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    var list = context.NhanViens.AsEnumerable().Select(nv => new NhanVienDTO
                    {
                        MaNhanVien = nv.MaNhanVien,
                        ChucVu = nv.ChucVu,
                        NgaySinh = nv.NgaySinh,
                        DiaChi = nv.DiaChi,
                        GioiTinh = nv.GioiTinh,
                        HoVaTen = nv.HoVaTen,
                        SDT = nv.SDT,
                        SoCMND = nv.SoCMND,
                        RowVersion = BitConverter.ToUInt64(nv.RowVersion, 0).ToString()
                    });
                    return list.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }
    }
}
