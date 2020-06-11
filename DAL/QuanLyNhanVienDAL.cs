using DTO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuanLyNhanVienDAL
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
                    NguoiTao = CurrentUser.Username
                    });
                    context.SaveChanges();
                    return true;
                }
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool XoaNhanVien(NhanVienDTO nv)
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    NhanVien nv_found = context.NhanViens.Single(p => p.MaNhanVien == nv.MaNhanVien);
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
                return false;
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
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public List<NhanVienDTO> DanhSachSinhVien()
        {
            using (QLRPContext context = new QLRPContext())
            {
                var list = context.NhanViens.Select(nv => new NhanVienDTO
                {
                    MaNhanVien = nv.MaNhanVien,
                    ChucVu = nv.ChucVu,
                    NgaySinh = nv.NgaySinh,
                    DiaChi = nv.DiaChi,
                    GioiTinh = nv.GioiTinh,
                    HoVaTen = nv.HoVaTen,
                    SDT = nv.SDT,
                    SoCMND = nv.SoCMND,
                });
                return list.ToList();
            }
        }
    }
}
