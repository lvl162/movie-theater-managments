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
                    NhanVien nv_found = context.NhanViens.SingleOrDefault(p => p.MaNhanVien == manv);
                    if (nv_found != null)
                    {
                        context.NhanViens.Remove(nv_found);
                        context.SaveChanges();
                        return true;
                    }
                    throw new Exception("Nhân viên này đã bị xóa bởi ai đó. Danh sách sẽ được load lại.");
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
                    NhanVien nv_found = context.NhanViens.SingleOrDefault(p => p.MaNhanVien == nv.MaNhanVien);
                    if (nv_found != null)
                    {
                        if (Utils.ValidateRowversion(nv_found.RowVersion, nv.RowVersion))
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
                        throw new Exception("Có ai đó đã update đối tượng này trước đó. Danh sách sẽ được load lại.");
                    }
                    throw new Exception("Nhân viên này đã bị xóa bởi ai đó. Danh sách sẽ được load lại.");
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Hiện tại, có ai đó cũng đang update đối tượng này. Danh sách sẽ được load lại.");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool IsHavingAccount(int manv)
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    foreach(var el in context.Logins.Select(p=>p).ToList())
                    {
                        if (el.MaNhanVien == manv)
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<NhanVienDTO> DanhSachNhanVien()
        {
            try
            {
                using (QLRPContext context = new QLRPContext())
                {
                    var list = context.NhanViens.Select(p => p).ToList();
                    var res = new List<NhanVienDTO>();
                    foreach (var nv in list)
                    {
                        string username = "Chưa có tài khoản";
                        if (nv.Login != null)
                        {
                            username = nv.Login.UserName;
                        }
                        NhanVienDTO n = new NhanVienDTO()
                        {
                            MaNhanVien = nv.MaNhanVien,
                            ChucVu = nv.ChucVu,
                            NgaySinh = nv.NgaySinh,
                            DiaChi = nv.DiaChi,
                            GioiTinh = nv.GioiTinh,
                            HoVaTen = nv.HoVaTen,
                            SDT = nv.SDT,
                            SoCMND = nv.SoCMND,
                            UserName = username,
                            RowVersion = BitConverter.ToUInt64(nv.RowVersion, 0).ToString()
                        };
                        res.Add(n);
                    }
                    return res;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }
    }
}
