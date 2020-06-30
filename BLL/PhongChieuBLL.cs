using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using Model;

namespace BLL
{
    public class PhongChieuBLL
    {
        PhongChieuDAL pcDAL = new PhongChieuDAL();
        
        public List<PhongChieuDTO> DanhSachPhongChieu() {
            try
            {
                return pcDAL.DanhSachPhongChieu();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool ThemPhong(string tenPhong, int soHang, int soCot)
        {
            try
            {
                return (pcDAL.ThemPhong(new PhongChieuDTO() { SoHang = soHang, TenPhong = tenPhong, SoCot = soCot }));
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public bool UpdatePhong(int ma, int soHang, int soCot, string tenphong, string rowVer)
        {
            try
            {
                return pcDAL.UpdatePhong(new PhongChieuDTO() { MaPhong = ma, SoHang = soHang, SoCot = soCot, TenPhong = tenphong, RowVersion = rowVer });
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public bool XoaPhong(int ma)
        {
            try
            {
                return (pcDAL.XoaPhong(ma));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
