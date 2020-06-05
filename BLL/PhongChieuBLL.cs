using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Model;

namespace BLL
{
    public class PhongChieuBLL
    {
        PhongChieuDAL pcDAL = new PhongChieuDAL();
        
        public void DanhSachPhongChieu(DataGridView dataGridView) {
            PhongChieuDAL dal = new PhongChieuDAL();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = dal.EF_GetAll();
        }
        public bool ThemPhong(int soghe, string tenphong)
        {
            PhongChieu phong = new PhongChieu() { SoGhe = soghe, TenPhong = tenphong };
            if (pcDAL.ThemPhong(phong)) return true;
            return false;
        }
        public bool UpdatePhong(int ma, int soghe, string tenphong)
        {
            PhongChieu phong = new PhongChieu() { MaPhong = ma, SoGhe = soghe, TenPhong = tenphong };
            if (pcDAL.UpdatePhong(phong)) return true;
            return false;
        }
        public bool XoaPhong(int ma, int soghe, string tenphong)
        {
            PhongChieu phong = new PhongChieu() { MaPhong = ma, SoGhe = soghe, TenPhong = tenphong };
            if (pcDAL.XoaPhong(phong)) return true;
            return false;
        }
    }
}
