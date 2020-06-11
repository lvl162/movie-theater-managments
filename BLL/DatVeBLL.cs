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
            return datVeDAL.LayDanhSachPhim();
        }
        public List<LichChieuDTO> LayDanhSachLichChieu(int MaPhim)
        {
            return datVeDAL.LayDanhSachLichChieuTuMaPhim(MaPhim);
        }
        public PhongChieuDTO LayPhongTheoLichChieu(int MaPhong)
        {
            return datVeDAL.LayPhongTheoLichChieu(MaPhong);
        }
    }
}
