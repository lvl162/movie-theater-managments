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
    public class QuanLyPhongChieuBLL
    {
        PhongChieuDAL pcDAL = new PhongChieuDAL();
        
        public List<PhongChieuDTO> DanhSachPhongChieu() {
            try
            {
                return pcDAL.DanhSachPhongChieu();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ThemPhong(int soghe, string tenphong)
        {
            try
            {
                PhongChieuDTO phong = new PhongChieuDTO() { SoGhe = soghe, TenPhong = tenphong };
                if (pcDAL.ThemPhong(phong)) return true;
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public bool UpdatePhong(int ma, int soghe, string tenphong, string rowVer)
        {
            PhongChieuDTO phong = new PhongChieuDTO() { MaPhong = ma, SoGhe = soghe, TenPhong = tenphong, RowVersion = rowVer };
            if (pcDAL.UpdatePhong(phong)) return true;
            return false;
        }
        public bool XoaPhong(int ma, int soghe, string tenphong)
        {
            PhongChieuDTO phong = new PhongChieuDTO() { MaPhong = ma, SoGhe = soghe, TenPhong = tenphong };
            if (pcDAL.XoaPhong(phong)) return true;
            return false;
        }
    }
}
