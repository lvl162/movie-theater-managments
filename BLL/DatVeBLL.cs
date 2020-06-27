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

        public PhongChieuDTO LayKieuPhong(int maPhong)
        {
            try
            {
                return datVeDAL.LayKieuPhong(maPhong);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<DatVeDTO> LichSuBanVe()
        {
            try
            {
                return datVeDAL.LichSuBanVe();
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
