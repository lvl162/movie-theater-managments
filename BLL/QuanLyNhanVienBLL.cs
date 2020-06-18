using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using Model;

namespace BLL
{
    public class QuanLyNhanVienBLL
    {
        QuanLyNhanVienDAL quanLyDAL = new QuanLyNhanVienDAL();
        public bool ThemNhanVien(string _HoTen, DateTime _NgaySinh, string _GioiTinh, string _SoCMND, string _SDT, string _ChucVu, string _DiaChi)
        {
            try
            {
                if (quanLyDAL.ThemNhanVien(new NhanVienDTO() { HoVaTen = _HoTen, NgaySinh = _NgaySinh, ChucVu = _ChucVu, GioiTinh = _GioiTinh, DiaChi = _DiaChi, SDT = _SDT, SoCMND = _SoCMND })) return true;
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public bool XoaNhanVien(int _maNV, string _HoTen, DateTime _NgaySinh, string _GioiTinh, string _SoCMND, string _SDT, string _ChucVu, string _DiaChi)
        {
            try
            {
                if (quanLyDAL.XoaNhanVien(new NhanVienDTO() { MaNhanVien = _maNV, HoVaTen = _HoTen, NgaySinh = _NgaySinh, ChucVu = _ChucVu, GioiTinh = _GioiTinh, DiaChi = _DiaChi, SDT = _SDT, SoCMND = _SoCMND })) return true;
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
        public bool UpdateNhanVien(int _maNV, string _HoTen, DateTime _NgaySinh, string _GioiTinh, string _SoCMND, string _SDT, string _ChucVu, string _DiaChi)
        {
            try
            {
                if (quanLyDAL.UpdateNhanVien(new NhanVienDTO() { MaNhanVien = _maNV, HoVaTen = _HoTen, NgaySinh = _NgaySinh, ChucVu = _ChucVu, GioiTinh = _GioiTinh, DiaChi = _DiaChi, SDT = _SDT, SoCMND = _SoCMND })) return true;
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public List<NhanVienDTO> DanhSachNhanVien()
        {
            try
            {
                return quanLyDAL.DanhSachSinhVien().ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}
