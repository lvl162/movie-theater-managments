using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Model;
namespace BLL
{
    public class PhimBLL
    {
        PhimDAL phimDAL = new PhimDAL();

        public void DanhSachPhim(DataGridView dataGridView)
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = phimDAL.EF_GetAll();
        }
        public bool ThemPhim(string ten, string theloai, DateTime khoichieu, string mota)
        {
            Phim p = new Phim() { TenPhim = ten, TheLoai = theloai, NgayKhoiChieu = khoichieu, MoTa = mota };
            if (phimDAL.ThemPhim(p)) return true;
            return false;
        }
        public bool XoaPhim(int ma, string ten, string theloai, DateTime khoichieu, string mota)
        {
            Phim p = new Phim() { MaPhim = ma, TenPhim = ten, TheLoai = theloai, NgayKhoiChieu = khoichieu, MoTa = mota };
            if (phimDAL.XoaPhim(p)) return true;
            return false;
        }
        public bool UpdatePhim(int ma, string ten, string theloai, DateTime khoichieu, string mota)
        {
            Phim p = new Phim() { MaPhim = ma, TenPhim = ten, TheLoai = theloai, NgayKhoiChieu = khoichieu, MoTa = mota };
            if (phimDAL.UpdatePhim(p)) return true;
            return false;
        }
    }
}
