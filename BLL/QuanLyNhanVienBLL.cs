using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace BLL
{
    public class QuanLyNhanVienBLL
    {
        QuanLyNhanVienDAL quanLyDAL = new QuanLyNhanVienDAL();
        public bool ThemNhanVien(string _HoTen, DateTime _NgaySinh, string _GioiTinh, string _SoCMND, string _SDT, string _ChucVu, string _DiaChi)
        {
            if (quanLyDAL.ThemNhanVien(new NhanVien() {HoVaTen = _HoTen, NgaySinh = _NgaySinh, ChucVu = _ChucVu, GioiTinh = _GioiTinh, DiaChi = _DiaChi, SDT = _SDT, SoCMND = _SoCMND})) return true;
            return false;
        }

        public bool XoaNhanVien(int _maNV, string _HoTen, DateTime _NgaySinh, string _GioiTinh, string _SoCMND, string _SDT, string _ChucVu, string _DiaChi)
        {
            if (quanLyDAL.XoaNhanVien(new NhanVien() { MaNhanVien = _maNV, HoVaTen = _HoTen, NgaySinh = _NgaySinh, ChucVu = _ChucVu, GioiTinh = _GioiTinh, DiaChi = _DiaChi, SDT = _SDT, SoCMND = _SoCMND })) return true;
            return false;
        }
        public bool UpdateNhanVien(int _maNV, string _HoTen, DateTime _NgaySinh, string _GioiTinh, string _SoCMND, string _SDT, string _ChucVu, string _DiaChi)
        {
            if (quanLyDAL.UpdateNhanVien(new NhanVien() { MaNhanVien = _maNV, HoVaTen = _HoTen, NgaySinh = _NgaySinh, ChucVu = _ChucVu, GioiTinh = _GioiTinh, DiaChi = _DiaChi, SDT = _SDT, SoCMND = _SoCMND })) return true;
            return false;
        }
        public void DanhSachNhanVien(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = quanLyDAL.DanhSachSinhVien().ToList();
        }
    }
}
