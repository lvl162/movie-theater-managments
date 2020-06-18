using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class DatVeBLL
    {
        DatVeDAL datVeDAL = new DatVeDAL();
        public List<PhimDTO> LayDanhSachPhim()
        {
            try
            {
                return datVeDAL.LayDanhSachPhim();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public List<LichChieuDTO> LayDanhSachLichChieu(int MaPhim)
        {
            try
            {
                return datVeDAL.LayDanhSachLichChieuTuMaPhim(MaPhim);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public PhongChieuDTO LayPhongTheoLichChieu(int MaPhong)
        {
            try
            {
                return datVeDAL.LayPhongTheoLichChieu(MaPhong);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
