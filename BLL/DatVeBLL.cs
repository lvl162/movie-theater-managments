using DAL;
using DTO;
using Model;
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

        public Dictionary<string, int> LayDSGhe(int maPhong)
        {
            try
            {
                return datVeDAL.LayDSGhe(maPhong);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<string> LayVeDaDat(int maLichChieu)
        {
            try
            {
                return datVeDAL.LayGheDaDat(maLichChieu);
            }
            catch (Exception)
            {

                throw;
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

        public bool DatVes(List<int> gheDaChon, int maLichChieu)
        {
            try
            {
                return datVeDAL.DatVes(gheDaChon, maLichChieu);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
