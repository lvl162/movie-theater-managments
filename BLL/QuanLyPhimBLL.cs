using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using Model;
namespace BLL
{
    public class QuanLyPhimBLL
    {
        QuanLyPhimDAL phimDAL = new QuanLyPhimDAL();

        public List<PhimDTO> DanhSachPhim()
        {
            try
            {
                return phimDAL.DanhSachPhim();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ThemPhim(string ten, string theloai, DateTime khoichieu, string mota)
        {
            try
            {
                PhimDTO p = new PhimDTO() { TenPhim = ten, TheLoai = theloai, NgayKhoiChieu = khoichieu, MoTa = mota };
                if (phimDAL.ThemPhim(p)) return true;
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool XoaPhim(int ma, string ten, string theloai, DateTime khoichieu, string mota)
        {
            try
            {
                PhimDTO p = new PhimDTO() { MaPhim = ma, TenPhim = ten, TheLoai = theloai, NgayKhoiChieu = khoichieu, MoTa = mota };
                if (phimDAL.XoaPhim(p)) return true;
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdatePhim(int ma, string ten, string theloai, DateTime khoichieu, string mota)
        {
            try
            {
                PhimDTO p = new PhimDTO() { MaPhim = ma, TenPhim = ten, TheLoai = theloai, NgayKhoiChieu = khoichieu, MoTa = mota };
                if (phimDAL.UpdatePhim(p)) return true;
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
