using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace BLL
{
    public class PhongChieuBLL
    {
        PhongChieuDAL pcDAL = new PhongChieuDAL();
        
        public void DanhSachPhongChieu(DataGridView dataGridView) {
            PhongChieuDAL dal = new PhongChieuDAL();
            dataGridView.DataSource = dal.EF_GetAll();
        }
        public bool ThemPhong(string ma, int soghe, float dt)
        {
            PhongChieu phong = new PhongChieu() { MaPhong = ma, SoGhe = soghe, DienTich = dt };
            if (pcDAL.ThemPhong(phong)) return true;
            return false;
        }
        public bool UpdatePhong(string ma, int soghe, float dt)
        {
            PhongChieu phong = new PhongChieu() { MaPhong = ma, SoGhe = soghe, DienTich = dt };
            if (pcDAL.UpdatePhong(phong)) return true;
            return false;
        }
        public bool XoaPhong(string ma, int soghe, float dt)
        {
            PhongChieu phong = new PhongChieu() { MaPhong = ma, SoGhe = soghe, DienTich = dt };
            if (pcDAL.XoaPhong(phong)) return true;
            return false;
        }
    }
}
