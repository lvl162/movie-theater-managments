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
        public bool ThemNhanVien(NhanVien nv)
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    context.NhanViens.Add(nv);
                    context.SaveChanges();
                    return true;
                }
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool XoaNhanVien(NhanVien nv)
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

        public bool UpdateNhanVien(NhanVien nv)
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
        public List<NhanVien> DanhSachSinhVien()
        {
            using (QLRPContext context = new QLRPContext())
            {
                var list = context.NhanViens.Select(p => p);
                return list.ToList();
            }
        }
    }
}
