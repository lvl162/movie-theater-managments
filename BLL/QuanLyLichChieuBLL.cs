using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QuanLyLichChieuBLL
    {
		QuanLyLichChieuDAL lichChieuDAL = new QuanLyLichChieuDAL();
        public List<LichChieuDTO> DanhSachLichChieu()
        {
			try
			{
				return lichChieuDAL.DanhSachLichChieu();
			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
